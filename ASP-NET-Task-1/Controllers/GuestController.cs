using System;
using System.Web.Mvc;
using DAL.Models;

namespace ASP_NET_Task_1.Controllers
{
    public class GuestController : Controller
    {
        public ActionResult Index()
        {
            return View(ReviewsData.Surveys);
        }
        [HttpPost]
        public ActionResult AddSurvey(Survey newSurvey)
        {
            newSurvey.PostDate = DateTime.Now;
            ReviewsData.Surveys.Add(newSurvey);
            return RedirectToAction("Index", "Guest");
        }
    }
}