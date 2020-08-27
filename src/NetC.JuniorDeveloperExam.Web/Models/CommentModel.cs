using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;

using NetC.JuniorDeveloperExam.Web.Business;

namespace NetC.JuniorDeveloperExam.Web.Models
{
    public class CommentModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM dd, yyyy - H:mm}")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        public string Message { get; set; }
        public Uri Avatar { get; private set; }

        public bool Reply { get; set; } = false;

        public List<CommentModel> Replies { get; set; }

        public CommentModel()
        {

        }

        public void SetReplies(List<Reply> replies)
        {
            for (int i = 0; i < replies.Count; i++)
            {
                CommentModel Reply = new CommentModel();

                Reply.Name = replies[i].Name;
                Reply.Date = replies[i].Date;
                Reply.EmailAddress = replies[i].EmailAddress;
                Reply.Message = replies[i].Message;
                Reply.SetAvatar();

                if (Replies != null)
                {
                    Replies.Add(Reply);
                }
                else
                {
                    Replies = new List<CommentModel>();
                    Replies.Add(Reply);
                }
            }
        }

        public void SetAvatar()
        {
            string[] name = Name.Split(' ');
            var url = new StringBuilder("https://eu.ui-avatars.com/api/?name=" + name[0]);
            for (int i = 1; i < name.Length; i++)
            {
                url.Append("+" + name[i]);
            }

            Avatar = new Uri(url.ToString());
        }
    }
}