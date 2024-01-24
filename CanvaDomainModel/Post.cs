namespace Post;

public class Post
{
    public int PostID { get; set; }
    public User Author { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }

    public Post(int postId, User author, string content, DateTime timestamp)
    {
        PostID = postId;
        Author = author;
        Content = content;
        Timestamp = timestamp;
    }

    public void Edit(string newContent)
    {
        // Implementation
    }

    public void Delete()
    {
        // Implementation
    }
}
