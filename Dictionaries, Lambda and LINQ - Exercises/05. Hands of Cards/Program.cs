using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> playersWithCards = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "JOKER")
            {
                string[] commandArgs = input.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                string playerName = commandArgs[0];
                string[] cards = commandArgs[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!playersWithCards.ContainsKey(playerName))
                {
                    playersWithCards.Add(playerName, new List<string>());
                }
                playersWithCards[playerName].AddRange(cards);
                input = Console.ReadLine();
            }

            PrintPlayersScores(playersWithCards);
        }

        private static void PrintPlayersScores(Dictionary<string, List<string>> playersWithCards)
        {
            foreach (var playerEntry in playersWithCards)
            {
                string playerName = playerEntry.Key;
                List<string> cards = playerEntry.Value.Distinct().ToList();
                int sum = 0;
                foreach (var card in cards)
                {
                    string rank = card.Substring(0, card.Length - 1);
                    string suite = card.Substring(card.Length - 1);

                    int rankPower = GetCardValue(rank);
                    int suitePower = GetSuite(suite);

                    sum += rankPower * suitePower;
                }

                Console.WriteLine("{0}: {1}", playerName, sum);
            }
        }

        private static int GetSuite(string suite)
        {
            switch (suite)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 1;
                    break;
            }
        }

        private static int GetCardValue(string rank)
        {
            switch (rank)
            {
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return 1;
                    break;
            }
        }
    }
}
