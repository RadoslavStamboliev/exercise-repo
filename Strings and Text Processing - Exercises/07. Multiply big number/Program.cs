using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart('0');
            string secondNumber = Console.ReadLine();
            if (firstNumber == "0" || secondNumber == "0")
            {
                Console.WriteLine(0);
                return;
            }

            if (firstNumber.Length < secondNumber.Length)
            {
                string temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp;
            }

            int inMind = 0;
            int remainder = 0;
            StringBuilder result = new StringBuilder();
            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                for (int j = secondNumber.Length - 1; j >= 0; j--)
                {
                    int sum = int.Parse(firstNumber[i].ToString()) * int.Parse(secondNumber[j].ToString()) + inMind;
                    inMind = sum / 10;
                    remainder = sum % 10;
                    result.Insert(0, remainder.ToString());
                    if (i == 0 && inMind != 0)
                    {
                        result.Insert(0, inMind.ToString());
                    }
                }

            }

            Console.WriteLine(result);
        }
    }
}
