using System.Web.Mvc;
using BLL.Services;

namespace ASP_NET_Task_1.Controllers
{
    public class HomeController : Controller
    {
        ArticlesService articlesService = new ArticlesService();
        public ActionResult Index()
        {
            var model = articlesService.GetAllArticles();
            return View(model);
        }
    }
}