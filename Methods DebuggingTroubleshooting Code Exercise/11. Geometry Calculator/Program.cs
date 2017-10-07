using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static double GetTriangleArea(double b, double h)
        {
            double area = b * h / 2;
            return area;
        }

        static double GetSquareArea(double a)
        {
            double area = a * a;
            return area;
        }

        static double GetReactangleArea(double width, double heightRec)
        {
            double area = width * heightRec;
            return area;
        }

        static double GetCircleArea(double r)
        {
            double area = Math.PI * r * r;
            return area;
        }

        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            
            if (figure=="triangle")
            {
                double b = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetTriangleArea(b, h));
            }
            else if (figure=="square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetSquareArea(a));
            }
            else if (figure=="rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double heightRec = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetReactangleArea(width, heightRec));
            }
            else if (figure=="circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetCircleArea(r));
            }
        }
    }
}
