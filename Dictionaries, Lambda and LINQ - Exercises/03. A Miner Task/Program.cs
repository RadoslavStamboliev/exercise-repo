using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, long>();
            string resourceType = Console.ReadLine();
            while (resourceType!="stop")
            {
                long resourceQuantity = long.Parse(Console.ReadLine());
                if (!resources.ContainsKey(resourceType))
                {
                    resources.Add(resourceType, 0);
                }
                resources[resourceType] += resourceQuantity;
                resourceType = Console.ReadLine();

            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
