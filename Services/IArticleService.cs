using stock_management.database.modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_management.Services
{
    public interface IArticleService
    {
        List<Article> getArticles();
        List<Article> getAvailableArticles();

        Article getArticle(int id);

        List<Article> getArticlesByRef(string refe);

        Article addArticle(Article article);

        Article updateArticle(Article article);

        void deleteArticle(int id);

    }
}
