using System;
using System.Web.Mvc;
using BLL.Services;
using DAL.Models;
using DAL.ViewModels;

namespace ASP_NET_Task_1.Controllers
{
    public class CommentController : Controller
    {
        CommentsService commentsService = new CommentsService();

        [HttpGet]
        public ActionResult Add(int? id)
        {
            if(id == null)
            {
                ViewBag.ArticleId = 1;
            }
            else
            {
                ViewBag.ArticleId = id;
            }
            return View();
        }
        [HttpPost]
        public ActionResult Add(CommentCreateViewModel model)
        {
            if(ModelState.IsValid)
            {
                Comment commentToAdd = new Comment();
                commentToAdd.Id = Guid.NewGuid().ToString();
                commentToAdd.AuthorName = model.AuthorName;
                commentToAdd.PostDate = DateTime.Now;
                commentToAdd.ArticleId = model.ArticleId;
                commentToAdd.ReviewText = model.Text;
                commentsService.Add(commentToAdd);

                return RedirectToAction("Details", "Article", new { id = Convert.ToInt32(model.ArticleId) });
            }
            return View();
        }
    }
}