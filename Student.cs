using System;

public class Student
{
    public string StudentName { get; private set; }
    public long StudentId { get; }
    public double GPA { get; private set; }

    public Student(string name, long id, double gpa)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException(
                "Student name cannot be empty.", nameof(name));

        if (double.IsNaN(gpa) || double.IsInfinity(gpa))
            throw new ArgumentOutOfRangeException(
                nameof(gpa), "GPA must be a finite number.");

        StudentName = name;
        StudentId = id;
        GPA = gpa;
    }

    public void Study()
    {
        Console.WriteLine(StudentName + " is studying...");
    }

    public void UpdateGPA(double newGpa)
    {
        if (double.IsNaN(newGpa) || double.IsInfinity(newGpa))
            throw new ArgumentOutOfRangeException(
                nameof(newGpa), "GPA must be a finite number.");

        GPA = newGpa;
    }
}
