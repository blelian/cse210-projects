using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 4);
        Rectangle rectangle = new Rectangle("Blue", 5, 2);
        Circle circle = new Circle("Green", 3);

        List<Shape> shapes = new List<Shape>
        {
            square,
            rectangle,
            circle
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.Color}, Area: {shape.GetArea()}");
        }
    }
}