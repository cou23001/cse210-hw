using System;

public class Circle: Shape
{
    private double _radius;

    public Circle (string color, double radius) : base(color)
    {
        SetRadius(radius);
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}