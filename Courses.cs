public class Course
{
    public string Name { get; }
    public int MaxSeats { get; }
    public List<Student> Students { get; } = new List<Student>();

    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
    }

    public void Enroll(Student student)
    {
        if (Students.Contains(student))
        {
            Console.WriteLine($"{student.Name} är redan anmäld till {Name}.");
            return;
        }

        if (Students.Count >= MaxSeats)
        {
            Console.WriteLine($"Kursen {Name} är full.");
            return;
        }

        Students.Add(student);
        if (!student.Courses.Contains(this))
        {
            student.Courses.Add(this);
        }
    }

    public void Remove(Student student)
    {
        if (!Students.Contains(student))
        {
            return;
        }

        Students.Remove(student);
        student.Courses.Remove(this);
    }

    public void RollCall()
    {
        Console.WriteLine($"Upprop för {Name}:");
        if (Students.Count == 0)
        {
            Console.WriteLine("  (inga studerande)");
            return;
        }

        foreach (var student in Students)
        {
            Console.WriteLine($"  - {student.Name}");
        }
    }

    public override string ToString() => $"{Name} ({Students.Count}/{MaxSeats} platser)";
}