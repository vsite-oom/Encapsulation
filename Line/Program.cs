using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.Oom
{
    class Point
    {
        public Point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public readonly double x;
        public readonly double y;
    }
    class Line
    {
        public Line(double k,double l)
        {
            this.k = k;
            this.l = l;
        }
        private double k;
        private double l;
        public Point Intersection(Line other)
        {
            if (k == other.k)
                return null;
            double x = (other.l - l) / (k - other.k);
            double y = k * x + l;
            return new Point(x, y);
            
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 


                

                Line l1 = new Line(1, 0);
                Line l2 = new Line(2, -1);
                Line l3 = new Line(3, -4);
                var p12 = l1.Intersection(l2);
                if (p12 == null)
                {
                    Console.WriteLine("Lines are paralel");
                }
                else
                Console.WriteLine($"Intersection: ({p12.x}, {p12.y})");

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry");
            }
        }

       
    }
}
