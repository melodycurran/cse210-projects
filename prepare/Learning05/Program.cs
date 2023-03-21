using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Square shape1 = new Square();
        shape1.SetColor("yellow");
        shape1.SetSide(4);

        Rectangle shape2 = new Rectangle();
        shape2.SetColor("red");
        shape2.SetLength(4);
        shape2.SetWidth(3);

        Circle shape3 = new Circle();
        shape3.SetColor("green");
        shape3.SetRadius(3);

        // Console.WriteLine($"The color is {shape1.GetColor()} and the area is {shape1.GetArea()}");
        // Console.WriteLine($"The color is {shape2.GetColor()} and the area is {shape2.GetArea()}");
        // Console.WriteLine($"The color is {shape3.GetColor()} and the area is {shape3.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The color is {shape.GetColor()} and the area is {shape.GetArea()}");
        }

        
    }
}