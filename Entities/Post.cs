using System.Text;

namespace Entities;

public class Post
{
    public DateTime Moment { get; set; }
    public String Title { get; set; }
    public String Content { get; set; }
    public int Likes { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();

    public Post(DateTime moment, string title, string content, int likes)
    {
        Moment = moment;
        Title = title;
        Content = content;
        Likes = likes;
    }

    public void addComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public Boolean removeComment(Comment comment)
    {
        return Comments.Remove(comment);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(Likes + " Likes - ");
        sb.AppendLine(Moment.ToString("dd/MM/yyyy hh:mm"));
        if(!String.IsNullOrEmpty(Title)) 
            sb.AppendLine(Title);
        sb.AppendLine(Content);
        sb.AppendLine("  Comments:");
        foreach(Comment comment in Comments){
            sb.Append("    - ");
            sb.AppendLine(comment.Text);
        }

        return sb.ToString();
    }
}
