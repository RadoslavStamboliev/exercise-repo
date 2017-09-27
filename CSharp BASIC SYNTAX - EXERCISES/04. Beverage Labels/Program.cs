using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyPer100ml = int.Parse(Console.ReadLine());
            int sugarPer100ml = int.Parse(Console.ReadLine());
            double totalEnergy = energyPer100ml / 100.0 * volume;
            double totalSugar = sugarPer100ml * volume / 100.0;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
        }
    }
}
