using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigit = 0;
                int digits = num;
                while (digits>0)
                {
                    sumOfDigit += digits % 10;
                    digits = digits / 10;
                }
                bool specialNumber = (sumOfDigit == 5) || (sumOfDigit == 7) || (sumOfDigit == 11);
                Console.WriteLine("{0} -> {1}", num, specialNumber);
            }
        }
    }
}
