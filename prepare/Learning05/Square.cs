using System;

public class Square: Shape
{
    private double _side;

    public Square(string color, double side): base(color) {
        SetSide(side);
    }

    public void SetSide(double side)
    {
        _side = side;
    }

    public double GetSide()
    {
        return _side;
    }

    public override double GetArea() 
    {
        return _side * _side;
    }
}