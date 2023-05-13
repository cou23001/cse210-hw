using System;

public class Rectangle: Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width): base(color)
    {
        SetLength(length);
        SetWidth(width);
    }

    public void SetLength(double length)
    {
        _length = length;
    }

    public void SetWidth(double width)
    {
        _width = width;
    }

    public double GetLength()
    {
        return _length;
    }

    public double GetWidth()
    {
        return _width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}