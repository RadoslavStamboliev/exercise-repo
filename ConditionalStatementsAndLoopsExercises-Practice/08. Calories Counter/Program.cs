using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int calories = 0;
            for (int i = 0; i < n; i++)
            {
                string ingredients = Console.ReadLine().ToLower();

                if (ingredients == "tomato sauce")
                {
                    calories = calories + 150;
                }
                if (ingredients == "cheese")
                {
                    calories = calories + 500;
                }
                if (ingredients == "salami")
                {
                    calories = calories + 600;
                }
                if (ingredients == "pepper")
                {
                    calories = calories + 50;
                }
            }
            Console.WriteLine("Total calories: " + calories);
        }
    }
}
