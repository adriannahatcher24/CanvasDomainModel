using System;
namespace Assignment;

public class Assignment
{
    public int AssignmentID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsPublished { get; private set; }

    public Assignment(int assignmentId, string title, string description, DateTime dueDate)
    {
        AssignmentID = assignmentId;
        Title = title;
        Description = description;
        DueDate = dueDate;
    }

    public void Publish()
    {
        IsPublished = true;
        LogAssignmentPublication(); 
    }

    private void LogAssignmentPublication()
    {
        Console.WriteLine($"Assignment {Title} published on {DateTime.Now}");
    }

    public void Submit()
    {
        Console.WriteLine($"{Title} has been submitted.");
    }

    public void Grade()
    {
        Console.WriteLine($"{Title} has been graded.");
    }
}

