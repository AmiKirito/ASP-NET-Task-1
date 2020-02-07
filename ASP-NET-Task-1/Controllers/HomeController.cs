using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_Task_1.Models;
using System.Net.Http;

namespace ASP_NET_Task_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(ArticleData.Articles);
        }
        public ActionResult Guest()
        {
            return View(ReviewsData.Surveys);
        }
        public ActionResult SurveyForm(FormCollection form)
        {
            if(HttpContext.Request.HttpMethod == HttpMethod.Post.Method)
            {
                List<string> data = new List<string>();
                for (int i = 0; i < form.AllKeys.Length; i++)
                {
                    if (form[form.AllKeys[i]] != "" && form[form.AllKeys[i]] != null)
                    {
                        try
                        {

                            data.Add(form[form.AllKeys[i]]);
                        }
                    catch { }
                    }
                }

                TempData["data"] = data;
                return RedirectToAction("Results","Home");
            }
            else
            {
                List<string> data = new List<string>() {"This is the first sentence in the list","And here's the second one","Oh, and here's the last one"};
                return View(data);
            }
        }
        [HttpPost]
        public ActionResult AddSurvey(Survey newSurvey)
        {
            newSurvey.PostDate = DateTime.Now;
            ReviewsData.Surveys.Add(newSurvey);
            return RedirectToAction("Guest", "Home");
        }
        public ActionResult Results()
        {
            var data = TempData["data"];
            return View(data);
        }
    }
}