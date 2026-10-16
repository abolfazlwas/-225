public class Teacher
{
    public string TeacherName { get; set; }
    public string Subject { get; set; }
    public int Experience { get; set; }

    public Teacher(string name, string subject, int exp)
    {
        TeacherName = name;
        Subject = subject;
        Experience = exp;
    }

    public void Teach()
    {
        System.Console.WriteLine(TeacherName + " is teaching " + Subject);
    }

    public void AddExperience()
    {
        Experience++;
    }
}
