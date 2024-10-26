using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning06 World!");
        // List
        List<Shape> shape = new List<Shape>();

        // Instance One
        Square sqr = new Square("red", 4);
        Console.WriteLine(sqr.GetColor());
        Console.WriteLine(sqr.GetArea());
        shape.Add(sqr);

        // For rectangle
        Rectangle rec = new Rectangle("blue", 4, 5);
        Console.WriteLine(rec.GetColor());
        Console.WriteLine(rec.GetArea());
        shape.Add(rec);

        // For Circle
        Circle cir = new Circle("green", 3.2);
        Console.WriteLine(cir.GetColor());
        Console.WriteLine(cir.GetArea());
        shape.Add(cir);

        // Loop Display
        Console.WriteLine("\n Loop Display\n");
        foreach(Shape item in shape)
        {
            Console.WriteLine(item.GetColor());
            Console.WriteLine(item.GetArea());
        }
    }
}