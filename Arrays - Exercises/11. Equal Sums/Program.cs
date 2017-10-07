using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool isFindEqualSums = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int[] lefSide = numbers.Take(i).ToArray();
                int[] rightSide = numbers.Skip(i+1).ToArray();
                if (lefSide.Sum()==rightSide.Sum())
                {
                    Console.WriteLine(i);
                    isFindEqualSums = true;
                    break;
                }
            }
            if (!isFindEqualSums)
            {
                Console.WriteLine("no");
            }
        }
    }
}
