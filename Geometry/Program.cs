using System;
using Geometry.ThirdParty;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangular rectangle = new Rectangle(3, 4);
            Console.WriteLine(rectangle);
            Console.WriteLine("Area:\t\t" + Calculator.GetArea(rectangle));
            Console.WriteLine("Perimeter:\t" + Calculator.GetPerimeter(rectangle));
            Console.WriteLine("Diagonal:\t" + Calculator.GetDiagonal(rectangle));

            Quadratic square = new Square(3);
            Rectangular rectSquare = new RectangleAdapter(square);
            Console.WriteLine(square);
            Console.WriteLine("Area:\t\t" + Calculator.GetArea(rectSquare));
            Console.WriteLine("Perimeter:\t" + Calculator.GetPerimeter(rectSquare));
            Console.WriteLine("Diagonal:\t" + Calculator.GetDiagonal(rectSquare));
        }
    }
}
