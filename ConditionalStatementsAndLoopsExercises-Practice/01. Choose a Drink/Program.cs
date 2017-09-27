using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            
            if (profession == "Athlete")
            {
                Console.WriteLine("Water");
            }
            else if (profession== "Businessman"||profession== "Businesswoman")
            {
                Console.WriteLine("Coffee"); 
            }
            else if (profession== "SoftUni Student")
            {
                Console.WriteLine("Beer"); 
            }
            else
            {
                Console.WriteLine("Tea"); 
            }
        }
    }
}
