namespace Assignment;

public class Assignment{
    public int AssignmentID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }

    public Assignment(int assignmentId, string title, string description, DateTime dueDate)
    {
        AssignmentID = assignmentId;
        Title = title;
        Description = description;
        DueDate = dueDate;
    }

    public void Submit()
    {
        
    }

    public void Grade()
    {
        
    }
}
