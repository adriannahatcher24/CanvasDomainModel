namespace Student;

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
        Courses.WriteLine($"{Name} enrolled im {course.Title}.")
    }

    public void SubmitAssignment(Assignment assignment)
    {
        Courses.WriteLine($"{Name} enrolled im {course.Title}.")
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
