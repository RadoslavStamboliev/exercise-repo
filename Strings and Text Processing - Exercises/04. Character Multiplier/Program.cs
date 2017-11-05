using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string first = input[0];
            string second = input[1];

            long sum = CalculateSum(first, second);

            Console.WriteLine(sum);
        }

        private static long CalculateSum(string first, string second)
        {
            char[] firstArr = first.ToCharArray();
            char[] secondArr = second.ToCharArray();
            long sum = 0;
            int minLength = Math.Min(firstArr.Length, secondArr.Length);
            int maxLength = Math.Max(firstArr.Length, secondArr.Length);

            for (int i = 0; i < minLength; i++)
            {
                sum += firstArr[i] * secondArr[i];
            }
            if (maxLength == firstArr.Length)
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    sum += firstArr[i];
                }
            }
            else
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    sum += secondArr[i];
                }
            }
            return sum;
        }
    }
}

