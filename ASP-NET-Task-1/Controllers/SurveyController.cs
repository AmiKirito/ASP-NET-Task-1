using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;

namespace ASP_NET_Task_1.Controllers
{
    public class SurveyController : Controller
    {
        public ActionResult Index(FormCollection form)
        {
            if (HttpContext.Request.HttpMethod == HttpMethod.Post.Method)
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
                return RedirectToAction("Results", "Survey");
            }
            else
            {
                List<string> data = new List<string>() { "This is the first sentence in the list", "And here's the second one", "Oh, and here's the last one" };
                return View(data);
            }
        }
        public ActionResult Results()
        {
            var data = TempData["data"];
            return View(data);
        }
    }
}