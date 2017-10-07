using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            int Search = 112;
            bool hasMatch = false;
            int counter = text.Length;
            for (int i = 0; i < text.Length; i++)
            {
                int current = text[i];
                if (current == Search)
                {
                    hasMatch = true;
                    int endIndex = jump;

                    if (endIndex >= counter)
                    {
                        endIndex = counter;
                    }
                    else
                    {
                        endIndex = jump + 1;
                    }
                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += jump;
                    counter -= jump + 1;
                }
                else
                {
                    counter--;
                }
            }
            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
