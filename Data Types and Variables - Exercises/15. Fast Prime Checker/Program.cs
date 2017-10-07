using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int curNum = 2; curNum <= num; curNum++)
            {
                bool isPrime = true;
                for (int devider = 2; devider <= Math.Sqrt(curNum); devider++)
                {
                    if (curNum % devider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{curNum} -> {isPrime}");
            }
        }
    }
}
