namespace Course;

public class Course
{
    public int CourseID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<Student> EnrollmentList { get; set; }
    public Instructor CourseInstructor { get; set; }
    public List<Assignment> Assignments { get; set; }


    public Course(int courseId, string title, string description, Instructor instructor)
    {
        CourseID = courseId;
        Title = title;
        Description = description;
        CourseInstructor = instructor;
        EnrollmentList = new List<Student>();
        Assignments = new List<Assignment>();

    }

    public void AddStudent(Student student)
    {
        EnrollmentList.Add(student);
    }

    public void RemoveStudent(Student student)
    {
        EnrollmentList.Remove(student);
    }

   public void PublishAssignment(Assignment assignment)
    {
        assignment.Publish();
        Assignments.Add(assignment);
        NotifyStudentsAboutAssignment(assignment); 
        LogAssignmentPublication(assignment);
    }

    private void NotifyStudentsAboutAssignment(Assignment assignment)
    {
        foreach (var student in EnrollmentList)
        {
            Console.WriteLine($"Notification sent to {student.Name}: New assignment published - {assignment.Title}");
        }
    }

    private void LogAssignmentPublication(Assignment assignment)
{
    Console.WriteLine($"Assignment {assignment.Title} published on {DateTime.Now}");
}
}
