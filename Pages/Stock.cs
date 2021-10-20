using stock_management.database.modles;
using stock_management.Services;
using stock_management.Services.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_management.Pages
{
    public partial class Stock : Form
    {
        private IArticleService articleService = new ArticleService();

        private List<Article> Articles { get; set; }
        private Article? selectedArticle;
        public Stock()
        {
            InitializeComponent();
        }

        

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (checkFeilds())
            {

                if (selectedArticle == null)
                {
                    var article = new Article() { Id = 0, Ref = refBox.Text, Name = nomBox2.Text, Price = (float)priceBox.Value, Quantity = (int)qntBox.Value };
                    articleService.addArticle(article);
                }
                else if (selectedArticle != null)
                {
                    var article = new Article() { Id = selectedArticle.Id, Ref = refBox.Text, Name = nomBox2.Text, Price = (float)priceBox.Value, Quantity = (int)qntBox.Value };
                    articleService.updateArticle(article);
                }
                clearBoxs();
                getAllArticles();
            } else
            {
                MessageBox.Show("Vous devez remplir tous les champs correctement");
            }
        }


        // clear all the inputs
        private void clearBoxs()
        {
            refBox.Text = "";
            nomBox2.Text = "";
            priceBox.Value = 0;
            qntBox.Value = 0;
            selectedArticle = null;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            timer.Start();
            stockpanel.Hide();
            Cursor.Current = Cursors.WaitCursor;
            getAllArticles();
            stockpanel.Show();
            Cursor.Current = Cursors.Default;
        }


        private void getAllArticles()
        {
            Articles = articleService.getArticles();
            dataGridView1.DataSource = Articles;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Sells"].Visible = false;
        }

        private void updateArticle(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedArticle = dataGridView1.SelectedRows[0].DataBoundItem as Article;
                refBox.Text = selectedArticle!.Ref;
                nomBox2.Text = selectedArticle.Name;
                priceBox.Value = (decimal)selectedArticle.Price;
                qntBox.Value = selectedArticle!.Quantity;

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            clearBoxs();
        }

        private void delete_Click(object sender, EventArgs e)
        {

            if(selectedArticle != null)
            {
                DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr ?", "Suppression", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                        articleService.deleteArticle(selectedArticle!.Id);
                        clearBoxs();
                        getAllArticles();

                }
            }
        }

        public bool checkFeilds()
        {
            if(refBox.Text.Trim() == "" || nomBox2.Text.Trim() == "" || priceBox.Value <= 0 || qntBox.Value < 0)
            {
                return false;
            }

            return true;
        }

        private void search_Click(object sender, EventArgs e)
        {
            if(searchInput.Text.Trim() != "")
            {
                var articles = articleService.getArticlesByRef(searchInput.Text);
                if (articles.ToArray().Length != 0)
                {
                    dataGridView1.DataSource = articles;
                }
                else
                {
                    MessageBox.Show("Aucun article n'a été trouvé");
                }
                searchInput.Text = "";
            }
        }

        private void reload_btn_Click(object sender, EventArgs e)
        {
            getAllArticles();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            day.Text = DateTime.Now.ToString("dddd  dd/MM/yyyy", CultureInfo.CreateSpecificCulture("fr-FR"));
            time.Text = DateTime.Now.ToString("HH:mm");
            second.Text = DateTime.Now.ToString("ss");
        }
    }
}
    