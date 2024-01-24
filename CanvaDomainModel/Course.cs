namespace Course;

public class Course
{
    public int CourseID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<Student> EnrollmentList { get; set; }
    public Instructor CourseInstructor { get; set; }

    public Course(int courseId, string title, string description, Instructor instructor)
    {
        CourseID = courseId;
        Title = title;
        Description = description;
        CourseInstructor = instructor;
        EnrollmentList = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        EnrollmentList.Add(student)
        Console.WriteLine($"{Student} is added to {Title}.");
    }

    public void RemoveStudent(Student student)
    {
        EnrollmentList.Remove(student)
        Console.WriteLine($"{Student} is removed from {Title}.");
    }

    public void PublishAssignment(Assignment assignment)
    {
        Console.WriteLine($"Assignment {assignment.Title} published in {Title}.");
    }
}
