using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Pokemon_Evolution
{
    class Evolutions
    {
        public string EvoName { get; set; }
        public int EvoIndex { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, List<Evolutions>>();

            while (input != "wubbalubbadubdub")
            {
                var tokens = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var pokeName = tokens[0];
                if (tokens.Length > 1)
                {

                    var pokeEvo = tokens[1];
                    var pokeIndex = int.Parse(tokens[2]);

                    var newEvolution = new Evolutions();
                    newEvolution.EvoName = pokeEvo;
                    newEvolution.EvoIndex = pokeIndex;

                    if (!result.ContainsKey(pokeName))
                    {
                        result[pokeName] = new List<Evolutions>();
                    }
                    result[pokeName].Add(newEvolution);
                }
                else
                {

                    if (result.ContainsKey(pokeName))
                    {
                        Console.WriteLine($"# {pokeName}");
                        foreach (var evoluton in result[pokeName])
                        {
                            Console.WriteLine($"{evoluton.EvoName} <-> {evoluton.EvoIndex}");
                        }
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var name in result)
            {
                Console.WriteLine($"# {name.Key}");
                foreach (var evoluton in name.Value.OrderByDescending(x => x.EvoIndex))
                {
                    Console.WriteLine($"{evoluton.EvoName} <-> {evoluton.EvoIndex}");
                }
            }
        }
    }
}
