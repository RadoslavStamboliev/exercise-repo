using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToList();
            List<long> aliveBehive=new List<long>();
            foreach (var behive in beehives)
            {
                if (hornets.Count==0)
                {
                    aliveBehive.Add(behive);
                    continue;
                }
                var power = hornets.Sum();
                if (power>=behive)
                {
                    if (power==behive)
                    {
                        hornets.RemoveAt(0);
                    }
                   
                }
                else
                {
                    aliveBehive.Add(behive-power);
                    hornets.RemoveAt(0);
                }

            }
            if (aliveBehive.Count!=0)
            {
                Console.WriteLine(string.Join(" ",aliveBehive));
            }
            else
            {
                Console.WriteLine(string.Join(" ",hornets));
            }
        }
    }
}
