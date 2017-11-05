using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberDays = double.Parse(Console.ReadLine());
            double numberOfRunners = double.Parse(Console.ReadLine());
            double averageNumberOfLaps = double.Parse(Console.ReadLine());
            double lapLenght = double.Parse(Console.ReadLine());
            double trackCapacity = double.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            double maxRunners = trackCapacity * numberDays;
            if (numberOfRunners>maxRunners)
            {
                numberOfRunners = maxRunners;
            }
            double totalMeters = numberOfRunners * averageNumberOfLaps * lapLenght;
            double totalKilometers = totalMeters / 1000.0;
            double totalMoneyRaised = totalKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {totalMoneyRaised:f2}");
        }
    }
}
