using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace NetC.JuniorDeveloperExam.Web.Business
{
    public class Comment
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("replies")]
        public List<Reply> Replies { get; set; }

        public void AddReply(Reply reply)
        {
            if (Replies != null)
            {
                Replies.Add(reply);
            }
            else
            {
                Replies = new List<Reply>();
                Replies.Add(reply);
            }
        }
    }
}