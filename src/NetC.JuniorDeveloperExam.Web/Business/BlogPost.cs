using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace NetC.JuniorDeveloperExam.Web.Business
{
    public class BlogPost
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("htmlContent")]
        public string HtmlContent { get; set; }

        [JsonProperty("comments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Comment> Comments { get; set; }

        public void AddComment(Comment comment)
        {
            if (Comments != null)
            {
                Comments.Add(comment);
            }
            else
            {
                Comments = new List<Comment>();
                Comments.Add(comment);
            }            
        }
    }
}