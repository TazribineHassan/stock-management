using stock_management.database.modles;
using stock_management.Services;
using stock_management.Services.Implementation;

namespace stock_management.Pages
{
    public partial class Vente : Form
    {

        private ISellService sellService = new SellService();

        private IArticleService articleService = new ArticleService();


        public Vente()
        {
            InitializeComponent();

            QuantityTextBox.ValueChanged += QuantityTextBoxChanged;

            ArticlesComboBox.DataSource = articleService.getArticles();
            ArticlesComboBox.DisplayMember = "Name";
            refresh();

        }

        private void refresh()
        {
            dataGridView1.Rows.Clear();
            List<Sell> sells = sellService.getSells();
            foreach (var sell in sells)
            {
                Article article = articleService.getArticle(sell.ArticleId);
                dataGridView1.Rows.Add(article.Ref, article.Name, article.Price, sell.Quantity, sell.Total);
            }
        }

        private void QuantityTextBoxChanged(object? sender, EventArgs e)
        {
            var qnt = ((NumericUpDown)sender).Value;
            var article = (Article)ArticlesComboBox.SelectedItem;

            if(article != null)
                totalLabel.Text = (int)qnt * article.Price + "";
        }


        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Sell newSell = new Sell();
            newSell.Quantity = (int)QuantityTextBox.Value;
            newSell.Article = (Article?)ArticlesComboBox.SelectedItem;
            newSell.Total = float.Parse(totalLabel.Text);
            newSell.Date = DateTime.Now;

            sellService.addSell(newSell);
            refresh();

        }

    }
}
