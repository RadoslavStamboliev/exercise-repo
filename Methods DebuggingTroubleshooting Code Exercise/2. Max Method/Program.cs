using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Max_Method
{
    class Program
    {
        static void GetMax(int a, int b,int c)
        {
            int firstCheck = Math.Max(a, b);
            int secondCheck = Math.Max(firstCheck, c);
            Console.WriteLine(secondCheck);
        }
        static void Main(string[] args)
        {
            int a =int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c =int.Parse(Console.ReadLine());
            GetMax(a, b, c);  
        }
    }
}
