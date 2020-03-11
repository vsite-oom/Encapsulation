using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.Oom
{
  
    class Point         
    {
        public readonly double X;
        public readonly double Y;
        public Point(double x, double y) {
            X = x;
            Y = x;
        }
    }
    class Line
    {
        private double k;
        private double l;
        public Line(double k, double l)
        {
            this.k = k;
        }
        public  Point Intersection(Line other)
        {

            if (k == other.k)
                return null;
          
           double x = (other.l - l) / (k - other.k);
           double y = k * x + l;
           return new Point(x, y);
               // Console.WriteLine($"Intersection: ({x}, {y})");
           
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            try
            {
                //List<double> k = new List<double> { 1, 2, 3 };
                //List<double> l = new List<double> { 0,-1,-4};
                //double k1 = double.Parse(args[0]);
                //double l1 = double.Parse(args[1]);
                //double k2 = double.Parse(args[2]);
                //double l2 = double.Parse(args[3]);
                Line l1 = new Line(1,0);
                Line l2 = new Line(2, -1);
                Line l3 = new Line(3, -4);
                var p12 = l1.Intersection(l2);
                if (p12 == null)
                    Console.WriteLine("Lines are paralel");
                else
                    Console.WriteLine($"Intersection: ({p12.X}, {p12.Y})");
                //Intersection(k[0],l[0],k[1],l[1]);
                //Intersection(k[0], l[0], k[2], l[2]);

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry");
            }
        }
        
    }
}
