using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(SquareRootPrecalculator.GetSqrt(number));
            }


        }
    }
}
