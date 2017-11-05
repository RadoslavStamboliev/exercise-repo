using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, Dictionary<long, decimal>> demons = new Dictionary<string, Dictionary<long, decimal>>();

            string input = Console.ReadLine();

            string patternInput = @"([^,\s][^\,]*[^,\s])";
            Regex rgxInput = new Regex(patternInput);

            MatchCollection matches = rgxInput.Matches(input);


            foreach (Match match in matches)
            {
                string name = match.Groups[1].Value;
                long hp = GetHp(name);
                decimal dmg = GetDmg(name);

                if (!demons.ContainsKey(name))
                {
                    demons.Add(name, new Dictionary<long, decimal> { { hp, dmg } });
                }
                else
                {
                    demons[name] = new Dictionary<long, decimal> { { hp, dmg } };
                }
            }
            foreach (var dem in demons.OrderBy(x => x.Key))
            {
                Console.Write($"{dem.Key} - ");
                foreach (var stats in dem.Value)
                {
                    Console.WriteLine($"{stats.Key} health, {stats.Value:f2} damage");
                }
            }
        }

        private static decimal GetDmg(string name)
        {
            string patternNumbers = @"([+-]?[0-9]+(?:\.[0-9]+)?)";
            Regex rgxNumbers = new Regex(patternNumbers);

            MatchCollection matches = rgxNumbers.Matches(name);

            decimal dmg = 0;

            foreach (Match match in matches)
            {
                decimal currentValue = decimal.Parse(match.Groups[1].Value.TrimStart('+'));

                dmg += currentValue;
            }

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == '*')
                {
                    dmg *= 2;
                }
                else if (name[i] == '/')
                {
                    dmg /= 2;
                }
            }

            return dmg;
        }

        private static long GetHp(string name)
        {
            string patternChars = @"([^0-9\+\-\*\/\.])";
            Regex rgxChars = new Regex(patternChars);

            MatchCollection filteredName = rgxChars.Matches(name);
            long sum = 0;
            foreach (Match chara in filteredName)
            {
                char c = char.Parse(chara.Groups[1].Value);
                sum += c;
            }


            return sum;
        }
    }
}

