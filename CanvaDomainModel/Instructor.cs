namespace Instructor;
using System;
using Course;
using Assignment;
using User;

public class Instructor : User
{
    public string Department { get; set; }
    public List<Course> Courses { get; set; }

    public Instructor(int userId, string name, string email, string department) 
        : base(userId, name, email)
    {
        Department = department;
        Courses = new List<Course>();
    }

    public void CreateCourse(Course course)
    {
        Courses.Add(course);
    }

    public void GradeAssignment(Assignment assignment)
    {
        assignment.Grade();
    }

    public override void Login()
    {
        Console.WriteLine($"{Name} logged in as Instructor.");
    }

    public override void Logout()
    {
        Console.WriteLine($"{Name} logged out.");
    }
}
