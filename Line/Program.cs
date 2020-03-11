using System;
using System.Collections.Generic;

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

        private double k;
        private double l;

        public double _k { get; set; }
        public double _l { get; set; }

        public Point Intersection(Line other)
        {
            if (k == other.k)
                return null;
            else
            {
                double x = (other.l - l) / (k - other.k);
                double y = k * x + l;
                return new Point(x, y);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<double> k = new List<double> { 1, 2, 3};
                List<double> l = new List<double> { 0, -1, -4};

                Line l1 = new Line(1, 0);
                Line l2 = new Line(2, -1);
                Line l3 = new Line(3, -4);

                var p12 = l1.Intersection(l2);
                if (p12 == null)
                {
                    Console.WriteLine("Lines are paralel");
                }
                else
                {
                    Console.WriteLine($"Intersection: ({p12.X}, {p12.Y})");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry");
            }
        }

        
    }
}
