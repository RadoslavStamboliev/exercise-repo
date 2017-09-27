using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstOne = int.Parse(Console.ReadLine());
            int secondOne = int.Parse(Console.ReadLine());
            int magicOne = int.Parse(Console.ReadLine());

            bool isMagicNumber = false;
            int counter = 0;
            int firstDigit = 0;
            int secondDigit = 0;
            for (int i = firstOne; i <= secondOne; i++)
            {
                if (isMagicNumber)
                {
                    break;
                }
                for (int j = firstOne; j <= secondOne; j++)
                {
                    counter++;
                    if (j + i == magicOne)
                    {
                        firstDigit = j;
                        secondDigit = i;
                        isMagicNumber = true;
                        break;
                    }
                }
            }

            if (isMagicNumber)
            {
                Console.WriteLine($"Number found! {firstDigit} + {secondDigit} = {magicOne}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicOne}");
            }
        }
    }
}
