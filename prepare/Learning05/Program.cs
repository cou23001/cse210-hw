using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Shapes");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Green", 2));
        shapes.Add(new Rectangle("Blue", 3, 2));
        shapes.Add(new Circle("Red",3));

        Square sq = new Square("Yellow Square", 5);
        Console.WriteLine($"Color: {sq.GetColor()} Area:{sq.GetArea()}");

        Rectangle re = new Rectangle("Yellow Rect", 5, 3);
        Console.WriteLine($"Color: {re.GetColor()} Area:{re.GetArea()}");

        Circle ci = new Circle("Yellow Circle", 7);
        Console.WriteLine($"Color: {ci.GetColor()} Area:{ci.GetArea()}");
        
        
        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Color: {s.GetColor()} Area:{s.GetArea()}");
        }
    }
}