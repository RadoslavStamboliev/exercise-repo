using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void FactorialTrailingZeroes(BigInteger factorial)
        {
            var counter = 0;
            for (int i = 0; i < factorial.ToString().Length; i++)
            {
                if (factorial % 10 == 0)
                {
                    counter++;
                    factorial /= 10;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
        static void GetFactorial(int number)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            FactorialTrailingZeroes(factorial);
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            GetFactorial(number);
        }
    }
}
