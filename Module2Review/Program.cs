using Module2Review;

class Program : Student
{
    static void Main(string[] args)
{
    List<Student> students = new List<Student>();

    
    Student student1 = new Student() { Name = "John", ID = 1 };
    Student student2 = new Student() { Name = "Alice", ID = 2 };
    Student student3 = new Student();
    student3.Name = "Bob";
    student3.ID = 3;
    Student student4 = new Student();
    student4.Name = "Eva";
    student4.ID = 4;

   
    students.Add(student1);
    students.Add(student2);
    students.Add(student3);
    students.Add(student4);

    
    student1.AddGrade(94.3);
    student1.AddGrade(90.0, 78.9, 95.4);

    student2.AddGrade(88.5, 91.2);
    student2.AddGrade(85.0);

    student3.AddGrade(75.6, 80.3, 77.8);

    student4.AddGrade(92.7);

    
    foreach (var student in students)
    {
        Console.WriteLine($"ID: {student.ID}, Name: {student.Name}");
        Console.Write("Grades: ");
        foreach (var grade in student.Grades)
        {
            Console.Write($"{grade}, ");
        }
        Console.WriteLine();
        Console.WriteLine($"Average Grade: {student.CalculateAverageGrade()}");
        Console.WriteLine();
    }
}
}