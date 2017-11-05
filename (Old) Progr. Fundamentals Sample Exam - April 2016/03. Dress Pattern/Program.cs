using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Dress_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int underLine = n * 4 - 2;
            int stars = 2;

            Console.WriteLine("{0}.{0}.{0}", new string('_', n * 4));

            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}.{1}.{0}.{1}.{0}", new string('_', underLine), new string('*', stars));
                stars += 3;
                underLine -= 2;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(".{0}{0}.", new string('*', stars - 2));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n * 3), new string('*', stars));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('_', n * 3), new string('o', stars));
            }

            underLine = n * 3;
            stars -= 2;

            for (int i = 0; i < n * 3; i++)
            {
                Console.WriteLine("{0}.{1}.{0}", new string('_', underLine), new string('*', stars));
                underLine--;
                stars += 2;
            }
            Console.WriteLine($"{new string('.', 12 * n + 2)}");
        }
    }
}
