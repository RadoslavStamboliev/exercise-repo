using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstCharArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondCharArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int minLen = Math.Min(firstCharArray.Length, secondCharArray.Length);
            for (int i = 0; i < minLen; i++)
            {
                if (firstCharArray[i]<secondCharArray[i])
                {
                    foreach (char ch in firstCharArray)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();
                    foreach (char ch1 in secondCharArray)
                    {
                        Console.Write(ch1);
                    }
                    Console.WriteLine();
                    return;
                }
                else if (secondCharArray[i]<firstCharArray[i])
                {
                    foreach (char ch in secondCharArray)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();
                    foreach (char ch1 in firstCharArray)
                    {
                        Console.Write(ch1);
                    }
                    Console.WriteLine();
                    return;
                }
            }
            if (firstCharArray.Length<secondCharArray.Length)
            {
                Console.WriteLine(new string(firstCharArray));
                Console.WriteLine(new string(secondCharArray));
            }
            else
            {
                Console.WriteLine(new string(secondCharArray));
                Console.WriteLine(new string(firstCharArray));
            }
        }
    }
}
