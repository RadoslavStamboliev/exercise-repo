using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double distanceFlaps = double.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            double distanceTraveled = wingFlaps / 1000 * distanceFlaps;
            Console.WriteLine($"{distanceTraveled:F2} m.");
            double timeOfBreaks = wingFlaps / endurance * 5;
            double timeTravelled = wingFlaps / 100;
            Console.WriteLine($"{timeOfBreaks+timeTravelled} s.");
        }
    }
}
