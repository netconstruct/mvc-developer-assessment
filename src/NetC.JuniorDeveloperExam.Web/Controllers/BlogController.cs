using NetC.JuniorDeveloperExam.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace NetC.JuniorDeveloperExam.Web.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            var webClient = new WebClient();// parse json file 
            var json = webClient.DownloadString(@"C:\Users\User\Source\Repos\mvc-developer-assessment\src\NetC.JuniorDeveloperExam.Web\App_Data\Blog-Posts.json");
            var blogPosts = JsonConvert.DeserializeObject<BlogPost>(json);
            //using JsonConvert.DeserializeObject we can pass BlogPosts class and list blogposts data json will be converting to blogposts and pass to the variable
            return View(blogPosts);
        }

        public JsonResult GetData(BlogPostsData blogPosts)
        {
            return Json(blogPosts.Comments, JsonRequestBehavior.AllowGet);
        }
    }
}