using System;

public class Program
{
    public static void Main()
    {
        Student myStudent = new Student("Abolfazl", 14042480051L, 15.5);

        myStudent.Study();

        Console.WriteLine("---");

        Teacher myTeacher = new Teacher("Dr. ali", "Programming", 10);

        myTeacher.Teach();

        Console.WriteLine("All tasks completed successfully!");
    }
}
