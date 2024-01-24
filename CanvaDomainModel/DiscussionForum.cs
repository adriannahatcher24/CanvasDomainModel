namespace DiscussionForum;

public class DiscussionForum
{
    public int ForumID { get; set; }
    public string Title { get; set; }
    public List<Post> Posts { get; set; }

    public DiscussionForum(int forumId, string title)
    {
        ForumID = forumId;
        Title = title;
        Posts = new List<Post>();
    }

    public void CreatePost(Post post)
    {
        // Implementation
    }

    public void DeletePost(Post post)
    {
        // Implementation
    }
}
