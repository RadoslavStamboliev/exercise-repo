using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static double FindFaceDiagonals(double side)
        {
            double result = Math.Sqrt(2 * (side * side));
            return result;
        }
        static double FindSpaceDiagonals(double side)
        {
            double result = Math.Sqrt(3 * (side * side));
            return result;
        }
        static double FindVolume(double side)
        {
            double result = side * side * side;
            return result;
        }
        static double FindSurfaceArea(double side)
        {
            double result = 6 * (side * side);
            return result;
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = (Console.ReadLine());

            if (parameter == "face")
            {
                Console.WriteLine("{0:F2}", FindFaceDiagonals(side));
            }
            else if (parameter == "space")
            {
                Console.WriteLine("{0:F2}", FindSpaceDiagonals(side));
            }
            if (parameter == "volume")
            {
                Console.WriteLine("{0:F2}", FindVolume(side));
            }
            if (parameter == "area")
            {
                Console.WriteLine("{0:F2}", FindSurfaceArea(side));
            }
        }
    }
}
