using DAL.Repositories;
using DAL.Models;

namespace BLL.Services
{
    public class ArticlesService
    {
        ArticlesRepository articlesRepository = new ArticlesRepository();
        public Article GetArticle(string id)
        {
            Article article = articlesRepository.DbGetArticle(id);
            return article;

        }
        public Article[] GetAllArticles()
        {
            Article[] articles = articlesRepository.DbGetAllArticles();
            return articles;
        }
    }
}
