using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _1.Most_Frequent_Number
{
    public class MostFrequentNumber
    {
        public static void Main(string[] args)
        {
            var input = File.ReadAllLines("Input.txt");

            var result= new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int[] numbers = input[i]
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                result[i] = $"Test {i + 1}: {MostFrequentinteger(numbers)}{Environment.NewLine}{new string('-', 10)}";
            }

            File.WriteAllLines("Output.txt", result);
        }

        private static string MostFrequentinteger(int[] numbers)
        {
            int counter = 1;
            int result = numbers[0];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int testCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        testCount++;
                    }
                }

                if (testCount > counter)
                {
                    counter = testCount;
                    result = numbers[i];
                }
            }

            return result.ToString();
        }
    }
}
