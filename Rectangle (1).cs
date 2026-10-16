using System;

public class Rectangle
{
    public double Width { get; private set; }
    public double Height { get; private set; }
    public string Color { get; }

    public Rectangle(double w, double h, string c)
    {
        ValidateDimension(w, nameof(w));
        ValidateDimension(h, nameof(h));

        if (string.IsNullOrWhiteSpace(c))
            throw new ArgumentException("Color cannot be empty.", nameof(c));

        Width = w;
        Height = h;
        Color = c;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public void Resize(double newW, double newH)
    {
        ValidateDimension(newW, nameof(newW));
        ValidateDimension(newH, nameof(newH));

        Width = newW;
        Height = newH;
    }

    private static void ValidateDimension(double value, string parameterName)
    {
        if (double.IsNaN(value) || double.IsInfinity(value) || value < 0)
            throw new ArgumentOutOfRangeException(parameterName, "Dimension must be a finite, non-negative number.");
    }
}
