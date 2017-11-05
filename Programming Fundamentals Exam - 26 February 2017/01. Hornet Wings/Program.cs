using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceWingFlat = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            double totalDistance = wingFlaps*distanceWingFlat/1000;
            int rest = wingFlaps / p;
            long seconds = rest * 5L;
            seconds += (wingFlaps / 100);
           
            Console.WriteLine($"{totalDistance:F2} m.");
           Console.WriteLine($"{seconds} s.");
        }
    }
}
