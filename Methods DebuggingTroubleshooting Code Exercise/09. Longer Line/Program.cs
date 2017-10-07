using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class Program
    {

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintPointClosestToCenter(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void PrintPointClosestToCenter(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double firstPair = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            double secondPair = Math.Pow(x2, 2) + Math.Pow(y2, 2);
            double thirdPair = Math.Pow(x3, 2) + Math.Pow(y3, 2);
            double fourPair = Math.Pow(x4, 2) + Math.Pow(y4, 2);

            double firstLine = Math.Pow(x1, 2) + Math.Pow(y1, 2) + Math.Pow(x2, 2) + Math.Pow(y2, 2);
            double secondLine = Math.Pow(x3, 2) + Math.Pow(y3, 2) + Math.Pow(x4, 2) + Math.Pow(y4, 2);

            if (GetLargerLine(firstLine, secondLine) == true)
            {
                if (GetLargerLine(firstPair, secondPair))
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                else
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
            }
            else if (GetLargerLine(firstLine, secondLine) == false)
            {
                if (GetLargerLine(thirdPair, fourPair))
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                else
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
            }
        }

        private static bool GetLargerLine(double first, double second)
        {
            if (first > second)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

