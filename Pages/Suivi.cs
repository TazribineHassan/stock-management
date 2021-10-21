using LiveCharts;
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
    public partial class Suivi : Form
    {

        private IDailyService dailyService = new DailyService();
        private IArticleService articleService = new ArticleService();


        public Suivi()
        {
            InitializeComponent();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Suivi_Load(object sender, EventArgs e)
        {
            timer.Start();
            
            suiviPanel.Hide();
            Cursor.Current = Cursors.WaitCursor;
            loadData();
            Cursor.Current = Cursors.Default;
            suiviPanel.Show();
        }

        private void loadData()
        {
            // load sells
            dataGridViewSuivi.Rows.Clear();
            List<Sell> sells = dailyService.getSells();
            foreach (var sell in sells)
            {
                Article article = articleService.getArticle(sell.ArticleId);
                if (article != null)
                    dataGridViewSuivi.Rows.Add(sell.Id, article.Id, sell.Date.ToShortDateString(), article.Ref, article.Name, article.Price, sell.Quantity, sell.Total);
            }
        }
        private void done_Click_1(object sender, EventArgs e)
        {
            // load sells
            dataGridViewSuivi.Rows.Clear();
            List<Sell> sells = dailyService.getSellsBetweenDates(startdate.Value, enddate.Value);
            if (sells.Count > 0)
            {
                foreach (var sell in sells)
                {
                    Article article = articleService.getArticle(sell.ArticleId);
                    if (article != null)
                        dataGridViewSuivi.Rows.Add(sell.Id, article.Id, sell.Date.ToShortDateString(), article.Ref, article.Name, article.Price, sell.Quantity, sell.Total);
                }
            }
            else
            {
                MessageBox.Show("Aucune vente n'a été trouvée");
            }

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            day.Text = DateTime.Now.ToString("dddd  dd/MM/yyyy", CultureInfo.CreateSpecificCulture("fr-FR"));
            time.Text = DateTime.Now.ToString("HH:mm");
            second.Text = DateTime.Now.ToString("ss");
        }

        private void suiviPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
