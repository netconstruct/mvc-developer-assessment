using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using NetC.JuniorDeveloperExam.Web.Models;

namespace NetC.JuniorDeveloperExam.Web.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BlogPost(int id)
        {
            var blogPost = new BlogPostModel(id);

            return View(blogPost);
        }

        [HttpPost]
        public ActionResult AddComment(BlogPostModel blogPost)
        {
            blogPost.AddComment();

            return RedirectToAction("BlogPost", "Blog", new { id = blogPost.Id });
        }

        [HttpPost]
        public ActionResult AddReply(BlogPostModel blogPost)
        {
            blogPost.AddReply(blogPost.SelectedCommentId);

            return RedirectToAction("BlogPost", "Blog", new { id = blogPost.Id });
        }
    }
}