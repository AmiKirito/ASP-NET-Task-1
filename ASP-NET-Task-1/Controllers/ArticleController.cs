using System.Web.Mvc;
using BLL.Services;

namespace ASP_NET_Task_1.Controllers
{
    public class ArticleController : Controller
    {
        ArticlesService articlesService = new ArticlesService();

        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                var model = articlesService.GetArticle("1");
                return View(model);
            }
            else
            {
                var model = articlesService.GetArticle(id.ToString());
                return View(model);
            }
        }
    }
}