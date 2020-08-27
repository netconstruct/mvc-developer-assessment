using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

using NetC.JuniorDeveloperExam.Web.Business;

namespace NetC.JuniorDeveloperExam.Web.Models
{
    public class BlogPostModel
    {
        public int Id { get; set; }
        public DateTime Date { get; private set; }
        public string Title { get; private set; }
        public Uri Image { get; private set; }
        public string HtmlContent { get; private set; }
        public List<CommentModel> CommentsModel { get; set; }
        public CommentModel NewComment { get; set; } = new CommentModel();
        public int SelectedCommentId { get; set; }

        public BlogPostModel()
        {

        }

        public BlogPostModel(int id)
        {
            BlogRoot root = JsonDeserializer.LoadBlogsPosts();
            List<BlogPost> blogPosts = root.BlogPosts;
            var blogPost = blogPosts.Where(x => x.Id == id).FirstOrDefault();

            Id = blogPost.Id;
            Date = blogPost.Date;
            Title = blogPost.Title;
            Image = blogPost.Image;
            HtmlContent = blogPost.HtmlContent;

            if (blogPost.Comments != null)
            {
                SetCommentsModel(blogPost.Comments);
            }      
            else
            {
                CommentsModel = new List<CommentModel>();
            }
        }

        private void SetCommentsModel(List<Comment> comments)
        {
            var commentsModel = new List<CommentModel>();

            for (int i = 0; i < comments.Count; i++)
            {
                var commentModel = new CommentModel();

                commentModel.Id = comments[i].Id;
                commentModel.Name = comments[i].Name;
                commentModel.Date = comments[i].Date;
                commentModel.EmailAddress = comments[i].EmailAddress;
                commentModel.Message = comments[i].Message;

                if (comments[i].Replies != null)
                {
                    commentModel.SetReplies(comments[i].Replies);
                }
                else
                {
                    commentModel.Replies = new List<CommentModel>();
                }              

                commentModel.SetAvatar();

                commentsModel.Add(commentModel);
            }

            CommentsModel = commentsModel;
        }

        public void AddComment()
        {
            BlogRoot root = JsonDeserializer.LoadBlogsPosts();

            Comment comment = new Comment();

            comment.Name = NewComment.Name;
            comment.Date = DateTime.Now;
            comment.EmailAddress = NewComment.EmailAddress;
            comment.Message = NewComment.Message;

            BlogPost blogPost = root.BlogPosts.Where(x => x.Id == this.Id).FirstOrDefault();
            comment.Id = blogPost.Comments == null ? 1 : blogPost.Comments.Count + 1;

            blogPost.AddComment(comment);
            JsonDeserializer.SaveToJson(root);
        }

        public void AddReply(int commentId)
        {
            Reply reply = new Reply();

            reply.Name = NewComment.Name;
            reply.Date = DateTime.Now;
            reply.EmailAddress = NewComment.EmailAddress;
            reply.Message = NewComment.Message;

            BlogRoot root = JsonDeserializer.LoadBlogsPosts();
            BlogPost blogPost = root.BlogPosts.Where(x => x.Id == this.Id).FirstOrDefault();
            Comment comment = blogPost.Comments.Where(x => x.Id == commentId).FirstOrDefault();

            comment.AddReply(reply);
            JsonDeserializer.SaveToJson(root);
        }
    }
}