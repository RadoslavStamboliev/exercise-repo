using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftUni_Airline
{
    class Program
    {
        public static void Main()
        {
            int flightsCount = int.Parse(Console.ReadLine());
            decimal overallProfit = CalcProfit(flightsCount);
            Console.WriteLine("Overall profit -> {0:f3}$.", overallProfit);
            Console.WriteLine("Average profit -> {0:f3}$.", overallProfit / flightsCount);
        }

        static decimal CalcProfit(int flightsCount)
        {
            decimal overallProfit = 0;
            for (int n = 0; n < flightsCount; n++)
            {
                decimal income = 0;
                for (int i = 0; i < 2; i++)
                {
                    decimal passengersCount = int.Parse(Console.ReadLine());
                    decimal ticketPrice = decimal.Parse(Console.ReadLine());
                    income += passengersCount * ticketPrice;
                }
                decimal expenses = 1;
                for (int i = 0; i < 2; i++)
                    expenses *= decimal.Parse(Console.ReadLine()); // fuel consumption * fuel price
                expenses *= int.Parse(Console.ReadLine()); // flight duration
                decimal profitPerFlight = income - expenses;
                overallProfit += profitPerFlight;
                if (profitPerFlight >= 0) Console.WriteLine("You are ahead with {0:f3}$.", profitPerFlight);
                else Console.WriteLine("We've got to sell more tickets! We've lost {0:f3}$.", profitPerFlight);
            }
            return overallProfit;
        }
    }
}
