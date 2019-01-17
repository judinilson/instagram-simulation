using System;
using System.Collections.Generic;
using System.Text;


namespace InstagramSimulation.Entites
{
    class Post
    {
        public DateTime moment { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public int likes { get; set; }
        List<Comment> comments { get; set; } = new List<Comment>();

        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            this.moment = moment;
            this.title = title;
            this.content = content;
            this.likes = likes;
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);

        }

        public void RemoveComment(Comment comment)
        {
            comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sub = new StringBuilder();
            sub.AppendLine(title);
            sub.Append(likes);
            sub.Append(" Likes - ");
            sub.AppendLine(moment.ToString("dd/mm/yy HH:mm:ss"));
            sub.AppendLine(content);
            sub.AppendLine("Comments: ");
            foreach(Comment c in comments)
            {
                sub.AppendLine(c.text);
            }
            return sub.ToString();
        }
    }
}
