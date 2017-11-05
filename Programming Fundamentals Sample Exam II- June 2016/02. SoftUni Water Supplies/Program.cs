using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Water_Supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalAmountOfWater = decimal.Parse(Console.ReadLine());
            var bottles = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse).ToArray();
            int bottleCapacity = int.Parse(Console.ReadLine());
            bool reversedArray = false;

            if (totalAmountOfWater%2!=0)
            {
                reversedArray = true;
                Array.Reverse(bottles);
            }
            int unfilledBottleIndex = -1;

            for (int i = 0; i < bottles.Length; i++)
            {
                decimal refil = bottleCapacity - bottles[i];
                if (totalAmountOfWater>refil)
                {
                    bottles[i] += refil;
                    totalAmountOfWater -= refil;
                }
                else
                {
                    bottles[i] += totalAmountOfWater;
                    totalAmountOfWater = 0;
                    if (bottles[i]<bottleCapacity)
                    {
                        unfilledBottleIndex = i;
                        break;
                    }
                }
            }
            if (unfilledBottleIndex==-1)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {totalAmountOfWater}l.");
            }
            else
            {
                    List<int> unfilledBottleIndices=new List<int>();
                for (int i = unfilledBottleIndex; i < bottles.Length; i++)
                {
                    if (!reversedArray)
                    {
                        unfilledBottleIndices.Add(i);
                    }
                    else
                    {
                        unfilledBottleIndices.Add(bottles.Length-1-i);
                    }
                }
                decimal waterStorage = 0;
                for (int i = unfilledBottleIndex; i < bottles.Length; i++)
                {
                    waterStorage += bottleCapacity - bottles[i];
                }
                Console.WriteLine("We need more water!");
                Console.WriteLine("Bottles left: {0}", unfilledBottleIndices.Count);
                Console.WriteLine("With indexes: {0}", string.Join(", ", unfilledBottleIndices));
                Console.WriteLine("We need {0} more liters!", waterStorage);
            }
        }
    }
}
