using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string>eventsID=new Dictionary<int, string>();
            Dictionary<string,List<string>>events=new Dictionary<string, List<string>>();

            string pattern = @"([0-9]+)\s+#\s*(\w+)\s*";

            Regex regex = new Regex(pattern);
            string command = Console.ReadLine();
            while (command != "Time for Code")
            {
                if (regex.IsMatch(command))
                {
                    Match match = regex.Match(command);
                    int ID = int.Parse(match.Groups[1].Value.Trim());
                    string eventName = match.Groups[2].Value.Trim();
                    string temp = Regex.Replace(command, @"\s+", "");
                    List<string> people=new List<string>();
                    if (temp.Contains("@"))
                    {
                        int startIndex = temp.IndexOf('@');
                        temp = temp.Substring(startIndex);
                        people = temp.Split(new char[] {'@'}, StringSplitOptions.RemoveEmptyEntries).ToList();

                    }
                    if (eventsID.ContainsKey(ID))
                    {
                        if (eventsID[ID]==eventName)
                        {
                            if (events.ContainsKey(eventName))
                            {
                                events[eventName].AddRange(people);
                            }
                            else
                            {
                                events.Add(eventName,people);
                            }
                        }
                    }
                    else
                    {
                        eventsID.Add(ID,eventName);
                        events.Add(eventName,people);
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var evenPair in events.OrderByDescending(x=>x.Value.Distinct().Count()).ThenBy(z=>z.Key))
            {
                Console.WriteLine($"{evenPair.Key} - {evenPair.Value.Distinct().Count()}");
                foreach (var person in evenPair.Value.Distinct().OrderBy(x=>x))
                {
                    Console.WriteLine($"@{person}");
                }
            }
        }
    }
}
