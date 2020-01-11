using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetC.JuniorDeveloperExam.Web.Models
{
    public class BlogPostsData
    {   
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public HttpPostedFileBase Image { get; set; }
        public string HtmlContent { get; set; }
        public string Comments { get; set; }
        public string BlogPosts { get; set; }
    }
}