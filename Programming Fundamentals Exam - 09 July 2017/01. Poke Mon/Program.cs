using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int CheckForCountOftargets = pokePower / distanceBetweenTargets;
            int CheckForRemainingPower = pokePower % distanceBetweenTargets;

            if (CheckForCountOftargets % 2 == 0 && CheckForRemainingPower == 0 && exhaustionFactor > 0)
            {
                pokePower = pokePower / 2 + ((pokePower / 2) / exhaustionFactor);
            }
            int countOftargets = pokePower / distanceBetweenTargets;
            int remainingPower = pokePower % distanceBetweenTargets;

            Console.WriteLine("{0}\n{1}", remainingPower, countOftargets);
        }
    }
}
