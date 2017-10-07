using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Greater_of_Two_Values
{
    class Program
    {
        static int GetIntMax(int first, int second)
        {
            int larger = 0;
            if (first >= second) larger = first;
            else larger = second;
            return larger;
        }

        static char GetCharMax(char first, char second)
        {
            char larger = (char)0x00;
            if (first >= second) larger = first;
            else larger = second;
            return larger;
        }

        static string GetStringMax(string first, string second)
        {
            string larger = string.Empty;
            if (first.CompareTo(second) >= 0) larger = first;
            else larger = second;
            return larger;
        }
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetIntMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = GetCharMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetStringMax(first, second);
                Console.WriteLine(max);
            }
        }
    }
}
