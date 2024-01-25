namespace Student;
using System;
using Course;
using Assignment;
using User;

public class Student : User
{
    public DateTime EnrollmentDate { get; set; }
    public List<Course> Courses { get; set; }

    public Student(int userId, string name, string email, DateTime enrollmentDate) 
        : base(userId, name, email)
    {
        EnrollmentDate = enrollmentDate;
        Courses = new List<Course>();
    }

    public void EnrollCourse(Course course)
    {
        Courses.Add(course);
    }

    public void SubmitAssignment(Assignment assignment)
    {
        assignment.Submit();
    }

    public override void Login()
    {
        Console.WriteLine($"{Name} logged in as Student.");
    }

    public override void Logout()
    {
        Console.WriteLine($"{Name} logged out.");
    }
}
