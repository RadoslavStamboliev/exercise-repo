using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;
            if (profession == "Athlete")
            {
                price = 0.70;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price = 1.00;
            }
            else if (profession == "SoftUni Student")
            {
                price = 1.70;
            }
            else
            {
                price = 1.20;
            }
            double totalPrice = price * quantity;
            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}
