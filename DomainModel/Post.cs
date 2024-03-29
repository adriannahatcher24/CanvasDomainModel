namespace Post;
using User;
using System;

public class Post
{
    public int PostID { get; set; }
    public User Author { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
    public bool IsDeleted { get; private set; }

    public Post(int postId, User author, string content, DateTime timestamp)
    {
        PostID = postId;
        Author = author;
        Content = content;
        Timestamp = timestamp;
        IsDeleted = false;
    }

    public void Edit(string newContent)
    {
        Content.newContent;
    }

    public void Delete()
    {
        IsDeleted = true;
    }
}
