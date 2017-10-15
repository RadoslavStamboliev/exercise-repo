using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lineOfDigits = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> lineOfCommands = Console.ReadLine().Split().Select(int.Parse).ToList();

            int takeThisDigits = lineOfCommands[0];
            int removeThisDigits = lineOfCommands[1];
            int checkThisOut = lineOfCommands[2];
            lineOfDigits.Take(takeThisDigits);
            foreach (var variable in lineOfDigits)
            {
               
            }
            
            lineOfDigits.RemoveRange(0, removeThisDigits);
            foreach (var variable in lineOfDigits)
            {
               
            }
           
            if (lineOfDigits.Contains(checkThisOut))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
