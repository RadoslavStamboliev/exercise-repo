using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Trophon_the_Grumpy_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> inputNums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToList();
            int idxInput = int.Parse(Console.ReadLine());
            string breakableItems = Console.ReadLine();
            string itemsToLookFor = Console.ReadLine();

            var leftSideNums = inputNums.Take(idxInput);
            var rightSideNums = inputNums.Skip(idxInput + 1);

            long entryPoint = inputNums[idxInput];

            long sumLeftNums;
            long sumRightNums;
            if (breakableItems == "cheap")
            {
                sumLeftNums = SumOfBrokenItems(leftSideNums.Where(x => x < entryPoint).ToList(), itemsToLookFor);
                sumRightNums = SumOfBrokenItems(rightSideNums.Where(x => x < entryPoint).ToList(), itemsToLookFor);
            }
            else
            {
                sumLeftNums = SumOfBrokenItems(leftSideNums.Where(x => x >= entryPoint).ToList(), itemsToLookFor);
                sumRightNums = SumOfBrokenItems(rightSideNums.Where(x => x >= entryPoint).ToList(), itemsToLookFor);
            }

            Console.WriteLine(sumRightNums > sumLeftNums ? $"Right - {sumRightNums}" : $"Left - {sumLeftNums}");
        }

        public static long SumOfBrokenItems(List<long> listNums, string word)
        {
            switch (word)
            {
                case "positive":
                    return listNums.Where(x => x > 0).Sum();
                case "negative":
                    return listNums.Where(x => x < 0).Sum();
                default:
                    return listNums.Sum();
            }
        }
    }
}
