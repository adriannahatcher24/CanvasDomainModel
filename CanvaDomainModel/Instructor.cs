namespace Instructor;

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
        Courses.WriteLine($"{Name} created {course.Title}.")
    }

    public void GradeAssignment(Assignment assignment)
    {
        Courses.WriteLine($"{Name} graded {assignment.Title}.")
    }

    public override void Login()
    {
        // Implementation
    }

    public override void Logout()
    {
        // Implementation
    }
}
