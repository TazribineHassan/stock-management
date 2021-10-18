﻿using stock_management.database.modles;
using stock_management.database;

namespace stock_management.Services.Implementation
{
    public class ArticleService : IArticleService
    {

        DatabaseContext context = new DatabaseContext();

        public Article addArticle(Article article)
        {
            context.Articles.Add(article);
            context.SaveChanges();
            return article;
        }

        public void deleteArticle(int id)
        {
            Article article = context.Articles.Where(article => article.Id == id).FirstOrDefault();
            if(article != null)
            {
                context.Articles.Remove(article);
            }

            context.SaveChanges();
            
        }

        public Article getArticle(int id)
        {
            return context.Articles.Where(article => article.Id == id).FirstOrDefault();
        }

        public List<Article> getArticles()
        {
            return context.Articles.ToList();
        }

        public Article updateArticle(Article article)
        {
            Article oldArticle = context.Articles.Where(oldArticle => oldArticle.Id == article.Id).FirstOrDefault();
            if (article == null)
            {
                throw new Exception("Article not found!");
            }

            oldArticle.Ref = article.Ref;

            context.SaveChanges();

            return oldArticle;
        }
    }
}