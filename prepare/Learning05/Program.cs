using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("green", 5);
        Console.WriteLine(square.GetArea());
        Rectangle rectangle = new Rectangle("blue", 6, 10);
        Console.WriteLine(rectangle.GetArea());
        Circle circle = new Circle("red", 5);
        Console.WriteLine(circle.GetArea());

        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(square);
        shapeList.Add(rectangle);
        shapeList.Add(circle);

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}