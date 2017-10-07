using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fibonacci_Numbers
{
    class Program
    {
        static void Fib(int n)
        {
            if (n == 0)
            {
                Console.WriteLine(1);
            }
            else if (n==1)
            {
                Console.WriteLine(1);
            }
            else
            {
                int fib0 = 1;
                int fib1 = 1;
                int fibNext = fib0+fib1;
                for (int i = 1; i < n-1; i++)
                {
                    fib0 = fib1;
                    fib1 = fibNext;
                    fibNext = fib0 + fib1;
                }
                Console.WriteLine(fibNext);
            }
           
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fib(n);
        }
    }
}
