using DAL.Models;
using System.Linq;

namespace DAL.Repositories
{
    public class ArticlesRepository
    {
        AppDbContext context = new AppDbContext();
        public Article DbGetArticle(string id)
        {
            Article article = context.Articles.Include("Comments").Where(a => a.Id == id).FirstOrDefault();
            return article;
        }
        public Article[] DbGetAllArticles()
        {
            Article[] articles = context.Articles.ToArray();
            return articles;
        }
    }
}
