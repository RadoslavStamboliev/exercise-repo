using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _04.Srabsko_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var performance = new Dictionary<string, Dictionary<string, long>>();

            while (line != "End")
            {
                var tokens = line.Split('@');
                if (tokens.Length != 2)
                {
                    line = Console.ReadLine();
                    continue;
                }

                if (tokens[0].EndsWith(" "))
                {
                    line = Console.ReadLine();
                    continue;
                }
                var rightSide = tokens[1].Split();

                if (rightSide.Length < 3)
                {
                    line = Console.ReadLine();
                    continue;
                }
                long ticketPrice;
                long ticketCount;

                if (!long.TryParse(rightSide[rightSide.Length - 1], out ticketPrice))
                {
                    line = Console.ReadLine();
                    continue;
                }

                if (!long.TryParse(rightSide[rightSide.Length - 2], out ticketCount))
                {
                    line = Console.ReadLine();
                    continue;
                }

                var singer = tokens[0].Trim();
                var venue = "";
                long totalPrice = ticketPrice * ticketCount;


                for (int i = 0; i < rightSide.Length - 2; i++)
                {
                    venue += rightSide[i] + " ";
                }

                venue = venue.Trim();
                if (!performance.ContainsKey(venue))
                {
                    performance[venue] = new Dictionary<string, long>();
                }

                if (!performance[venue].ContainsKey(singer))
                {
                    performance[venue][singer] = 0;
                }
                performance[venue][singer] += totalPrice;
                line = Console.ReadLine();
            }
            foreach (var venueAndSingers in performance)
            {
                string venue = venueAndSingers.Key;
                Dictionary<string, long> singers = venueAndSingers.Value;
                Console.WriteLine(venue);
                foreach (var singerAndPrice in singers.OrderByDescending(s => s.Value))
                {
                    string singer = singerAndPrice.Key;
                    long totalPrice = singerAndPrice.Value;
                    Console.WriteLine($"#  {singer} -> {totalPrice}");
                }
            }
        }
    }
}
