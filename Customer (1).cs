using System;

public class Customer
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Email { get; private set; }

    public Customer(string name, int age, string email)
    {
        ValidateName(name);
        ValidateAge(age);
        ValidateEmail(email);

        Name = name;
        Age = age;
        Email = email;
    }

    public void ShowDetails()
    {
        Console.WriteLine("Customer: " + Name);
    }

    public void UpdateEmail(string newEmail)
    {
        ValidateEmail(newEmail);
        Email = newEmail;
    }

    private static void ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Customer name cannot be empty.", nameof(name));
    }

    private static void ValidateAge(int age)
    {
        if (age < 0)
            throw new ArgumentOutOfRangeException(nameof(age), "Age cannot be negative.");
    }

    private static void ValidateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || email.StartsWith("@") || email.EndsWith("@"))
            throw new ArgumentException("A basic valid email address is required.", nameof(email));
    }
}
