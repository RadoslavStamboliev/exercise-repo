using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            var soldiers = new Dictionary<string, Dictionary<string, long>>();
            var legionActivity = new Dictionary<string, long>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new[] { '=', '-', '>', ':', ' ' }
                    , StringSplitOptions.RemoveEmptyEntries);

                long activity = long.Parse(tokens[0]);
                string legionName = tokens[1];
                string soldierType = tokens[2];
                long count = long.Parse(tokens[3]);

                if (!legionActivity.ContainsKey(legionName))
                {
                    legionActivity.Add(legionName, activity);
                    soldiers.Add(legionName, new Dictionary<string, long>());
                }

                if (!soldiers[legionName].ContainsKey(soldierType))
                {
                    soldiers[legionName][soldierType] = 0;
                }

                if (legionActivity[legionName] < activity)
                {
                    legionActivity[legionName] = activity;
                }

                soldiers[legionName][soldierType] += count;
            }

            string[] commands = Console.ReadLine().Split('\\');

            if (commands.Length == 1)
            {
                string soldType = commands[0];
                foreach (var legion in legionActivity.OrderByDescending(l => l.Value))
                {
                    if (soldiers[legion.Key].ContainsKey(soldType))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }
            else
            {
                int searchedActivity = int.Parse(commands[0]);
                string type = commands[1];

                foreach (var legion in soldiers.Where(l => l.Value.ContainsKey(type))
                    .OrderByDescending(l => l.Value[type]))
                {
                    if (legionActivity[legion.Key] < searchedActivity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legion.Value[type]}");
                    }
                }
            }

            //Dictionary<string,Dictionary<string,int>> legionSoldiers=new Dictionary<string, Dictionary<string, int>>();
            //Dictionary<string,int>legionActivities=new Dictionary<string, int>();

            //var n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    var inputArgs = Console.ReadLine().Split(new string[] {" = " ," -> "}, StringSplitOptions.RemoveEmptyEntries);
            //    int activity = int.Parse(inputArgs[0]);
            //    string legion = inputArgs[1];
            //    string soldiers = inputArgs[2];
            //    int count = int.Parse(inputArgs[3]);

            //    if (!legionActivities.ContainsKey(legion))
            //    {
            //        legionActivities.Add(legion,activity);
            //    }
            //    else
            //    {
            //        if (activity>legionActivities[legion])
            //        {
            //            legionActivities[legion] = activity;
            //        }
            //        else
            //        {
            //            legionActivities[legion]=activity;
            //        }
            //    }
            //    if (legionSoldiers.ContainsKey(legion))
            //    {
            //        legionSoldiers.Add(legion,new Dictionary<string, int>());
            //        legionSoldiers[legion].Add(soldiers,count);
            //    }
            //    else
            //    {
            //        if (!legionSoldiers[legion].ContainsKey(soldiers))
            //        {
            //            legionSoldiers[legion].Add(soldiers,count);
            //        }
            //        else
            //        {
            //            legionSoldiers[legion][soldiers] += count;
            //        }

            //    }
            //}
            //var printArgs = Console.ReadLine().Split('\\');
            //if (printArgs.Length>1)
            //{
            //    int activity = int.Parse(printArgs[0]);
            //    string soldier = printArgs[1];

            //    foreach (var legion in legionSoldiers.Where(legion=>legionActivities[legion.Key]<activity)
            //        .OrderByDescending(legion=>legion.Value[soldier]))
            //    {
            //        Console.WriteLine($"{legion.Key} -> {legion.Value[soldier]}");

            //    }
            //}
            //else
            //{
            //    string soldier = printArgs[0];
            //    foreach (var legion in legionActivities.Where(legion=>legionSoldiers[legion.Key].ContainsKey(soldier)).OrderByDescending(legion=>legion.Value))
            //    {
            //        Console.WriteLine($"{legionActivities[legion.Key]} -> {legion.Key}");
            //    }
            //}
        }
    }
}
