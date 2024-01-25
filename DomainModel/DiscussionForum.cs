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
        Posts.Add(post);
    }

    public void DeletePost(Post post){

    if (Posts.Contains(post))
    {
        Posts.Remove(post);
        Console.WriteLine("Post removed successfully.");
    }
    else
    {
        Console.WriteLine("The post does not exist in the forum.");
    }
}
}
