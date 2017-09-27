using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int smallerNumber = Math.Min(firstNumber, secondNumber);
            int biggerNumber = Math.Max(firstNumber, secondNumber);
         
            for (int interval = smallerNumber; interval <= biggerNumber; interval++)
            {
                Console.WriteLine(interval);
            }
        }
    }
}
