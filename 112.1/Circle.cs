using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _112._1
{
    static class Circle
    {
        private static readonly double pi = 3.1416;
        static public double Perimeter(double R)
        {
            return 2 * R * pi;
        }

        static public double Face(double R)
        {
            return pi * R * R;
        }
    }

    static class Sphere
    {
        private static readonly double pi = 3.1416;
        static public double Surface(double R)
        {
            return 4 * pi * R * R;
        }
        static public double Volume(double R)
        {
            return 4 * pi * R * R * R / 3;
        }
    }
}
