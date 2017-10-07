using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                long number = long.Parse(input);
                Console.WriteLine($"{number} can fit in:");
                if (number >= sbyte.MinValue && sbyte.MaxValue >= number)
                {
                    Console.WriteLine($"* sbyte");
                }
                if (number >= byte.MinValue && byte.MaxValue >= number)
                {
                    Console.WriteLine($"* byte");
                }
                if (number >= short.MinValue && short.MaxValue >= number)
                {
                    Console.WriteLine($"* short");
                }
                if (number >= ushort.MinValue && ushort.MaxValue >= number)
                {
                    Console.WriteLine($"* ushort");
                }
                if (number >= int.MinValue && int.MaxValue >= number)
                {
                    Console.WriteLine($"* int");
                }
                if (number >= uint.MinValue && uint.MaxValue >= number)
                {
                    Console.WriteLine($"* uint");
                }
                if (number >= long.MinValue && long.MaxValue >= number)
                {
                    Console.WriteLine($"* long");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
