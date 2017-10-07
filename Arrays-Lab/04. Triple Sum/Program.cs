using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool notFound = false;
            for (int a = 0; a < input.Length; a++)
            {
                for (int b = a+1; b < input.Length; b++)
                {
                    for (int c = 0; c < input.Length; c++)
                    {
                        int sum = input[a] + input[b];
                        if (input[a] + input[b] == input[c])
                        {
                            Console.WriteLine($"{input[a]} + {input[b]} == {input[c]}");
                            notFound = true;
                            break;
                        }
                    }
                }
            }
            if (!(notFound))
            {
                Console.WriteLine("No");
            }
        }
    }
}
