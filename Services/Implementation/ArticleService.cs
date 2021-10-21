using stock_management.database.modles;
using stock_management.database;

namespace stock_management.Services.Implementation
{
    public class ArticleService : IArticleService
    {

        DatabaseContext context = new DatabaseContext();

        public ArticleService()
        {
            context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public Article addArticle(Article article)
        {
            context.Articles.Add(article);
            context.SaveChanges();
            return article;
        }

        public void deleteArticle(int id)
        {
            Article article = context.Articles.Include("Sells").Where(article => article.Id == id).FirstOrDefault();

            if(article != null)
            {
                if(article.Sells.Count() == 0)
                    context.Articles.Remove(article);
                else
                    article.Deleted = true;
            }

            context.SaveChanges();
            
        }

        public Article getArticle(int id)
        {
            return context.Articles.Where(article => article.Id == id).FirstOrDefault();
        }

        public List<Article> getArticles()
        {
            return context.Articles.AsNoTracking().Where( article => !article.Deleted).ToList();
        }

        public List<Article> getArticlesByRef(string refe)
        {
            return context.Articles.Where(article => article.Ref == refe).ToList();
        }

        public List<Article> getAvailableArticles()
        {
            return context.Articles.Where(article => article.Quantity > 0).ToList();
        }

        public Article updateArticle(Article article)
        {
            Article oldArticle = context.Articles.Where(oldArticle => oldArticle.Id == article.Id).FirstOrDefault();
            if (article == null)
            {
                throw new Exception("Article not found!");
            }

            oldArticle!.Ref = article!.Ref;
            oldArticle.Name = article.Name;
            oldArticle.Price = article.Price;
            oldArticle.Quantity = article.Quantity;
            
            context.SaveChanges();

            return oldArticle;
        }
    }
}
