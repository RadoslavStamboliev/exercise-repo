using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Longer_Line
{
    class Program
    {

        static void Main(string[] args)
        {
            double x1=0.0;
            double x2=0.0;
            double y1=0.0;
            double y2=0.0;

            double maxLineLenght = double.MinValue;
            double maxX1=0.0;
            double maxX2=0.0;
            double maxY1=0.0;
            double maxY2=0.0;
            for (int i = 0; i < 2; i++)
            {
                x1 = double.Parse(Console.ReadLine());
                y1 = double.Parse(Console.ReadLine());

                x2 = double.Parse(Console.ReadLine());
                y2 = double.Parse(Console.ReadLine());
                double line = FindLine(x1,x2,y1,y2);
                if (line>maxLineLenght)
                {
                    maxLineLenght = line;
                    maxX1 = x1;
                    maxX2 = x2;
                    maxY1 = y1;
                    maxY2 = y2;
                } 
            }
           
              PrintResult(maxX1, maxX2, maxY1 ,maxY2);
            //double hypotenuseOne =Math.Abs(Math.Sqrt(x1 * x1 + y1 * y1));
            //double hypotenuseTwo=Math.Abs(Math.Sqrt(x2 * x2 + y2 * y2));

          
        }
        static void PrintResult(double x1, double x2, double y1, double y2)
        {
            double hypotenuseOne= Math.Abs(Math.Sqrt(x1 * x1 + y1 * y1));
            double hypotenuseTwo=Math.Abs(Math.Sqrt(x2 * x2 + y2 * y2));
            if (hypotenuseTwo>hypotenuseOne)
            {
             
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
        static double FindLine(double x1, double x2, double y1, double y2)
        {
           
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
    }
}
