using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            string word1 = input[0];
            string word2 = input[1];

            var arrayOne = word1.ToCharArray().Distinct().ToArray();
            var arrayTwo = word2.ToCharArray().Distinct().ToArray();

            if (arrayOne.Length==arrayTwo.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
