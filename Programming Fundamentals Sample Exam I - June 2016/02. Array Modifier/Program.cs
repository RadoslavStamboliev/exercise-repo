using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();
            var input = Console.ReadLine();
            while (input != "end")
            {
                string[] operation = input.Split(' ');
                if (operation[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = numbers[i] - 1;
                    }
                }
                int[] indexes = new int[2];
                if (operation.Length <= 1)
                {
                    indexes[0] = 0;
                    indexes[1] = 0;
                }
                else
                {
                    indexes[0] = int.Parse(operation[1]);
                    indexes[1] = int.Parse(operation[2]);
                }
                if (operation[0] == "swap")
                {
                    var temp = numbers[indexes[0]];
                    numbers[indexes[0]] = numbers[indexes[1]];
                    numbers[indexes[1]] = temp;
                }
                if (operation[0] == "multiply")
                {
                    var temp = numbers[indexes[0]] * numbers[indexes[1]];
                    numbers[indexes[0]] = temp;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

