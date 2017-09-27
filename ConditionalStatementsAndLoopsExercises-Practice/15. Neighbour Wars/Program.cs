using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;

            int turn = 1;

            while (peshoHealth > 0 || goshoHealth > 0)
            {
                if (turn % 2 == 0 && turn != 0)
                {
                    peshoHealth = peshoHealth - goshoDamage;
                    if (peshoHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                    }
                    else
                    {
                        Console.WriteLine($"Gosho won in {turn}th round."); break;
                    }
                }
                else
                {
                    goshoHealth = goshoHealth - peshoDamage;
                    if (goshoHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    }
                    else
                    {
                        Console.WriteLine($"Pesho won in {turn}th round."); break;
                    }
                }

                if (turn % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
                turn++;
            }
        }
    }
}
