using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNumber = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(currentNumber);
                sum += currentNumber;
                currentNumber += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
