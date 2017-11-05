using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Hornet_Armada
{
    class Program
    {
        class Legion
        {
            public string Name { get; set; }
            public long LastActivity { get; set; }
            public Dictionary<string, long> SoldiersTypeAndCount { get; set; }
        }

        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            List<Legion> listOfLegions = new List<Legion>();
            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine()
                    .Split(new string[] {" = ", " -> ", ":"}, StringSplitOptions.RemoveEmptyEntries);
                long activity = long.Parse(data[0]);
                string name = data[1];
                string type = data[2];
                long count = long.Parse(data[3]);
                bool alreadyThere = false;
                foreach (var singleLegion in listOfLegions)
                {
                    if (singleLegion.Name == name)
                    {
                        alreadyThere = true;
                        if (singleLegion.LastActivity < activity)
                        {
                            singleLegion.LastActivity = activity;
                        }
                        if (singleLegion.SoldiersTypeAndCount.ContainsKey(type))
                        {
                            singleLegion.SoldiersTypeAndCount[type] += count;
                        }
                        else
                        {
                            singleLegion.SoldiersTypeAndCount.Add(type, count);
                        }
                    }
                }
                if (!alreadyThere)
                {
                    Legion legion = new Legion();
                    legion.LastActivity = activity;
                    legion.Name = name;
                    legion.SoldiersTypeAndCount = new Dictionary<string, long>();
                    legion.SoldiersTypeAndCount.Add(type, count);
                    listOfLegions.Add(legion);
                }

            }
            string output = Console.ReadLine();
            if (output.Contains("\\"))
            {
                PrintSoldiersAndActivity(output, listOfLegions);
            }
            else
            {
                PrintAllSoldiersOfTHisType(listOfLegions, output);
            }
        }

        static void PrintAllSoldiersOfTHisType(List<Legion> listOfLegions, string output)
        {
            var orderedLegions = listOfLegions.OrderByDescending(x => x.LastActivity);
            foreach (var thisLegion in orderedLegions)
            {
                foreach (var soldierTypeCount in thisLegion.SoldiersTypeAndCount)
                {
                    if (soldierTypeCount.Key == (output))
                    {
                        Console.WriteLine($"{thisLegion.LastActivity} : {thisLegion.Name}");
                    }
                }
            }
        }

        static void PrintSoldiersAndActivity(string output, List<Legion> listOfLegions)
        {
            var outputData = output.Split(new char[] {'\\'});
            var orderedLegions = listOfLegions.Where(x => x.SoldiersTypeAndCount.ContainsKey(outputData[1]))
                .OrderByDescending(x => x.SoldiersTypeAndCount[outputData[1]]);
            foreach (var thisLegion in orderedLegions)
            {
                foreach (var soldierTypeCount in thisLegion.SoldiersTypeAndCount)
                {
                    if (soldierTypeCount.Key == (outputData[1]) && thisLegion.LastActivity < long.Parse(outputData[0]))
                    {
                        Console.WriteLine($"{thisLegion.Name} -> {soldierTypeCount.Value}");
                    }
                }
            }
        }
    }
}
