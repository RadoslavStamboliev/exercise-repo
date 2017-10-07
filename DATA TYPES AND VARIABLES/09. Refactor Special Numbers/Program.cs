using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int num = 1; num <= number; num++)
            {
                int sumDigit = 0;
                int digit = num;
                while (digit > 0)
                {
                    sumDigit += digit % 10;
                    digit = digit / 10;
                }
                bool special = (sumDigit == 5) || (sumDigit == 7) || (sumDigit == 11);
                Console.WriteLine("{0} -> {1}", num, special);
            }

        }
    }
}
