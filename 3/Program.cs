using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Geometry.SquarePerimeter(5));
            Console.WriteLine(Geometry.SquareArea(5));
            Console.WriteLine(Geometry.RectanglePerimeter(1, 2));
            Console.WriteLine(Geometry.RectangleArea(1, 2));
            Console.WriteLine(Geometry.CircleArea(10));
        }
    }
}
