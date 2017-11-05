using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeLeaves = DateTime.Parse(Console.ReadLine());
            //Махам цели дни ако някой ги добавя 
            int steps = int.Parse(Console.ReadLine()) % 86400;
            int timeInSeconds = int.Parse(Console.ReadLine()) % 86400;
            long sumSteps = steps * timeInSeconds;
            DateTime result = timeLeaves.AddSeconds(sumSteps);
            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", result);
        }
    }
}
