using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Temperature_Conversion
{
    class Program
    {
        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        static void Main(string[] args)
        {
            var fahrengeit = double.Parse(Console.ReadLine());
            var celsius = FahrenheitToCelsius(fahrengeit);
            Console.WriteLine("{0:F2}",celsius);
        }
    }
}
