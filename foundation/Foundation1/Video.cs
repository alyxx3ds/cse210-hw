using System.Collections.Generic;
using System.Text;

public class Video
{
    private string title;
    private string author;
    private int length;
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public string GetVideoDetails()
    {
        StringBuilder details = new StringBuilder();
        details.AppendLine($"Title: {title}");
        details.AppendLine($"Author: {author}");
        details.AppendLine($"Length: {length} seconds");
        details.AppendLine($"Number of Comments: {GetCommentCount()}");

        foreach (Comment comment in comments)
        {
            details.AppendLine(comment.GetCommentDetails());
        }

        return details.ToString();
    }
}