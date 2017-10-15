using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> logs = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string commandLine = Console.ReadLine();
                ProcessData(commandLine, logs);
            }
            SortAndPrintData(logs); 
        }
        static void ProcessData(string commandLine,Dictionary<string,Dictionary<string,int>>logs)
        {
            List<string> data = commandLine.Split().ToList();
            string IP = data[0];
            string userID = data[1];
            int time = int.Parse(data[2]);
            if (logs.ContainsKey(userID))
            {
                if (logs[userID].ContainsKey(IP))
                {
                    logs[userID][IP] += time;
                }
                else
                {
                    logs[userID].Add(IP, time);
                }
            }
            else
            {
                logs.Add(userID, new Dictionary<string, int> { { IP, time } });
            }
        }
        static void SortAndPrintData(Dictionary<string,Dictionary<string,int>>logs)
        {
            foreach (var user in logs.OrderBy(x=>x.Key))
            {
                Console.Write($"{user.Key}: {user.Value.Values.Sum()} [");
                int commaCounter = 0;
                foreach (var data in user.Value.OrderBy(x=>x.Key))
                {
                    Console.Write($"{data.Key}");
                    if (commaCounter<user.Value.Count-1)
                    {
                        Console.Write(", ");
                        commaCounter++;
                    }
                    else
                    {
                        Console.WriteLine("]");
                    }
                }
            }
        }
    }
}
