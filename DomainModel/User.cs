namespace User;

public abstract class User
{
    public int UserID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    protected User(int userId, string name, string email)
    {
        UserID = userId;
        Name = name;
        Email = email;
    }

    public abstract void Login();
    public abstract void Logout();
}

