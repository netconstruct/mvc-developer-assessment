using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetC.JuniorDeveloperExam.Web.Business
{
    public class BlogRoot
    {
        [JsonProperty("blogPosts")]
        public List<BlogPost> BlogPosts {get;set;}
    }
}