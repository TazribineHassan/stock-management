using stock_management.database;
using stock_management.database.modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_management.Services.Implementation
{
    public class SellService : ISellService
    {

        DatabaseContext context = new DatabaseContext();

        IArticleService articleService = new ArticleService();

        public Sell addSell(Sell sell)
        {

            if (sell.Quantity > sell.Article.Quantity)
                throw new Exception("Stock insuffisant");

            sell.ArticleId = sell.Article.Id;

            var total = sell.Article.Price * sell.Quantity;
            sell.Total = total;

            sell.Article.Quantity -= sell.Quantity;
            articleService.updateArticle(sell.Article);

            context.Sells.Add(sell);
            context.SaveChanges();
            return sell;
        }

        public void deleteSell(int id)
        {
            Sell Sell = context.Sells.Where(Sell => Sell.Id == id).FirstOrDefault();
            if (Sell != null)
            {
                context.Sells.Remove(Sell);
            }

            context.SaveChanges();

        }

        public Sell getSell(int id)
        {
            return context.Sells.Where(Sell => Sell.Id == id).FirstOrDefault();
        }

        public List<Sell> getSells()
        {
            return context.Sells.ToList();
        }

        public Sell updateSell(Sell sell)
        {
            Sell oldSell = context.Sells.Where(oldSell => oldSell.Id == sell.Id).FirstOrDefault();
            if (oldSell == null)
            {
                throw new Exception("Sell not found!");
            }

            oldSell.Article = articleService.getArticle(oldSell.ArticleId);

            if(oldSell.Article.Id == sell.Article.Id)
            {
                Article article = oldSell.Article;
                article.Quantity = article.Quantity + oldSell.Quantity - sell.Quantity;

                if (article.Quantity < 0)
                    throw new Exception("stock insuffisant");
                
                articleService.updateArticle(article);
            }
            else
            {
                Article article = oldSell.Article;
                article.Quantity = article.Quantity + oldSell.Quantity;
                articleService.updateArticle(article);

                var newArticle = articleService.getArticle(sell.Article.Id);

                if (sell.Quantity > newArticle.Quantity)
                    throw new Exception("Insuffisant stock");

                newArticle.Quantity = newArticle.Quantity - sell.Quantity;
                articleService.updateArticle(newArticle);
            }

            oldSell.Quantity = sell.Quantity;
            oldSell.Date = sell.Date;
            oldSell.Article = sell.Article;

            context.SaveChanges();

            return oldSell;
        }
    }
}
