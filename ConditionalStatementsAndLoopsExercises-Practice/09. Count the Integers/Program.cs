using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInt = 0;
            try
            {
                while (true)
                {
                    int numbers = int.Parse(Console.ReadLine());
                    numberInt++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(numberInt);
            }
        }
    }
}
