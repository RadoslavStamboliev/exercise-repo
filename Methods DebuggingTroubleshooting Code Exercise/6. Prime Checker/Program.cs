using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Prime_Checker
{
    class Program
    {
        static bool isPrime(long n)
        {
            if (n == 0)
            {
                return false;
            }
            else if (n == 1)
            {
                return false;
            }
            else if (n == 2)
            {
                return true;
            }
            else if (n % 2 != 0)
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
            static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(n));
        }
    }
}
