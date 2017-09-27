using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberIngredients = 0;

            while (true)
            {

                string ingredients = Console.ReadLine();
                if (ingredients != "Bake!")
                {
                    numberIngredients++;
                    Console.WriteLine($"Adding ingredient {ingredients}.");
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {numberIngredients} ingredients.");
                    break;
                }
            }
        }
    }
}
