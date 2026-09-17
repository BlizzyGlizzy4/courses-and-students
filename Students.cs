public class Student
{
    public string Name { get; }
    public List<Course> Courses { get; } = new List<Course>();

    public Student(string name)
    {
        Name = name;
    }

    public void Join(Course course)
    {
        course.Enroll(this);
    }

    public void Leave(Course course)
    {
        course.Remove(this);
    }

    public void Schedule()
    {
        Console.WriteLine($"Schema för {Name}:");
        if (Courses.Count == 0)
        {
            Console.WriteLine("  (inga kurser)");
            return;
        }

        foreach (var course in Courses)
        {
            Console.WriteLine($"  - {course.Name}");
        }
    }

    public override string ToString() => Name;
}