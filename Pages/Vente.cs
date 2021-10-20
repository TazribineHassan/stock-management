using stock_management.database.modles;
using stock_management.Services;
using stock_management.Services.Implementation;
using System.Globalization;

namespace stock_management.Pages
{
    public partial class vente : Form
    {

        private ISellService sellService = new SellService();

        private IArticleService articleService = new ArticleService();

        private Sell selectedSell;


        public vente()
        {
            InitializeComponent();

        }

        private void refresh()
        {
            // load articles
            ArticlesComboBox.DataSource = articleService.getAvailableArticles();
            ArticlesComboBox.DisplayMember = "Name";

            // load sells
            dataGridView1.Rows.Clear();
            List<Sell> sells = sellService.getSells();
            foreach (var sell in sells)
            {
                dataGridView1.Rows.Add(sell.Id, sell.Article.Id, sell.Date.ToShortDateString(), sell.Article.Ref, sell.Article.Name, sell.Article.Price, sell.Quantity, sell.Total);
            }
            clearBoxes();
        }
         
        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (checkFeilds())
            {

                Sell newSell = new Sell();
                newSell.Quantity = (int)QuantityTextBox.Value;
                newSell.Article = (Article?)ArticlesComboBox.SelectedItem;
                newSell.Total = float.Parse(totalLabel.Text);
                newSell.Date = DateTime.Now;

                if (selectedSell == null)
                {
                    try
                    {
                        sellService.addSell(newSell);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        newSell.Id = selectedSell.Id;
                        sellService.updateSell(newSell);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
                refresh();
                clearBoxes();
            }
            else
            {
                MessageBox.Show("Vous devez remplir tous les champs correctement");
            }

        }

        public bool checkFeilds()
        {
            if (ArticlesComboBox.SelectedItem == null || QuantityTextBox.Value == null)
            {
                return false;
            }

            return true;
        }

        private void refreshButtonClicked(object sender, EventArgs e)
        {
            refresh();
        }

        private void deleteButtonClicked(object sender, EventArgs e)
        {
            if (selectedSell != null)
            {
                DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr ?", "Suppression", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sellService.deleteSell(selectedSell!.Id);
                    clearBoxes();
                    refresh();
                }
            }
        }

        private void searchButtonClicked(object sender, EventArgs e)
        {
            
        }

        private void Vente_Load(object sender, EventArgs e)
        {
            timer.Start();
            Cursor.Current = Cursors.WaitCursor;
            QuantityTextBox.ValueChanged += QuantityTextBoxChanged;
            refresh();
            Cursor.Current = Cursors.Default;
        }

        private void QuantityTextBoxChanged(object? sender, EventArgs e)
        {
            var qnt = ((NumericUpDown)sender).Value;
            var article = (Article)ArticlesComboBox.SelectedItem;

            if (article != null)
                totalLabel.Text = (int)qnt * article.Price + "";
        }

        private void updateSell(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                selectedSell = new Sell()
                {
                    Id = int.Parse(selectedRow.Cells["ID"].Value.ToString()),
                    Article = articleService.getArticle(int.Parse(selectedRow.Cells["ARTICLE_ID"].Value.ToString())),
                    ArticleId = int.Parse(selectedRow.Cells["ARTICLE_ID"].Value.ToString()),
                    Quantity = int.Parse(selectedRow.Cells["Quantity"].Value.ToString()),
                    Total = float.Parse(selectedRow.Cells["Total"].Value.ToString())
                };
                ArticlesComboBox.SelectedItem = articleService.getArticles().Find(article => article.Id == selectedSell.Article.Id);
                QuantityTextBox.Value = selectedSell.Quantity;
                totalLabel.Text = selectedSell.Total.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
}

        private void resetButtonClicked(object sender, EventArgs e)
        {
            clearBoxes();
        }

        private void clearBoxes()
        {
            ArticlesComboBox.SelectedItem = null;
            QuantityTextBox.Value = 0;
            totalLabel.Text = 0 + "";
            selectedSell = null;
        }

        private void comboBoxChanged(object sender, EventArgs e)
        {
            Article article = (sender as ComboBox).SelectedItem as Article;
            if (article == null)
            {
                prixLabel.Text = "0";
                totalLabel.Text = "0";
                return;
            }

            prixLabel.Text = article.Price.ToString();
            totalLabel.Text = (int)QuantityTextBox.Value * article.Price + "";
        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            day.Text = DateTime.Now.ToString("dddd  dd/MM/yyyy", CultureInfo.CreateSpecificCulture("fr-FR"));
            time.Text = DateTime.Now.ToString("HH:mm");
            second.Text = DateTime.Now.ToString("ss");
        }
    }
}
