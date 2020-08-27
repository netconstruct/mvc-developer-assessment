using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace NetC.JuniorDeveloperExam.Web.Business
{
    public static class JsonDeserializer
    {
        public static void SaveToJson(BlogRoot root)
        {
            string path = HostingEnvironment.MapPath(@"~\App_Data\Blog-Posts.json");

            string convertedJson = JsonConvert.SerializeObject(root, Formatting.Indented);
            File.WriteAllText(path, convertedJson);
        }

        public static BlogRoot LoadBlogsPosts()
        {
            string path = HostingEnvironment.MapPath(@"~\App_Data\Blog-Posts.json");
            string jsonFromFile;
            using (StreamReader reader = File.OpenText(path))
            {
                jsonFromFile = reader.ReadToEnd();
                var root = JsonConvert.DeserializeObject<BlogRoot>(jsonFromFile);

                return root;
            }
        }


    }
}