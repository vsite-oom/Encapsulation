using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.Oom
{
    class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public readonly double X;
        public readonly double Y;
    }

    class Line
    {
        public Line(double k, double l)
        {
            this.k = k;
            this.l = l;
        }

        public Point Intersection(Line other)
        {
            if (k == other.k)
                return null;

            double x = (other.l - l) / (k - other.k);
            double y = k * x + l;
            return new Point(x, y);

        }

        private double k;
        private double l;
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double k1 = double.Parse(args[0]);
                double l1 = double.Parse(args[1]);
                double k2 = double.Parse(args[2]);
                double l2 = double.Parse(args[3]);
                Line l1 = new Line(1, 0);
                Line l2 = new Line(2, -1);
                Line l3 = new Line(3, -4);

                if (k1 == k2)
                    var p12 = l1.Intersection(l2);
                if (p12 == null)
                    Console.WriteLine("Lines are paralel");
                else
                {
                    double x = (l2 - l1) / (k1 - k2);
                    double y = k1 * x + l1;
                    Console.WriteLine($"Intersection: ({x}, {y})");
                }
                Console.WriteLine($"Intersection: ({p12.X}, {p12.Y})");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry");
            }
        }
    }
}
