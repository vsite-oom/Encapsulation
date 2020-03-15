using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.Oom
{
 class Program
    {
        class Point
        {
            public readonly double x;
            public readonly double y;
            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }
        class Line
        {
            private double k;
            private double l;
            public Line (double k, double l)
            {
                this.k = k;
                this.l = l;
            }
            public Point Intersection(Line other)
            {
                if (k == other.k)
                    return null;
                double x = (other.l - l) / (k - other.k);
                double y = y = k * x + 1;
                return new Point(x, y);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Line l1 = new Line(1, 0);
                Line l2 = new Line(2, -1);
                Line l3 = new Line(3, -4);
                var p12 = l1.Intersection(l2);
                if(p12 == null)
                    Console.WriteLine("Linije su paralelne");
                else
                    Console.WriteLine($"Intersection: ({p12.x}, {p12.y})");
            }
            catch(Exception)
            {
                Console.WriteLine("Pogrešan unos");
            }
        }
        private static void Intersection (double k1, double k2, double l1, double l2)
        {
            if ( k1 == k2)
                Console.WriteLine("Linije su paralelne");
            else
            {
                double x = (l2 - l1) / (k1 - k2);
                double y = k1 * x + l1;
                Console.WriteLine($"Intersection: ({x}, {y})");
            }
        }
    }   
}
