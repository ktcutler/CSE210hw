using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Square mysquare = new Square("Red", 15);
        shapes.Add(mysquare);

        Rectangle myrectangle = new Rectangle("Red", 5, 5);
        shapes.Add(myrectangle);

        Circle mycircle = new Circle("Red", 3);
        shapes.Add(mycircle);
        
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}