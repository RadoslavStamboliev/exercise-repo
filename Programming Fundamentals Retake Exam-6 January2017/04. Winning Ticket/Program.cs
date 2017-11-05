using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allTickets = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Regex winningTicket = new Regex(@"([$]{6,}|[@]{6,}|[\^]{6,}|[#]{6,})");
            Regex jackpotTicket = new Regex(@"([$]{20}|[@]{20}|[\^]{20}|[#]{20})");

            string[] result = new string[allTickets.Length];

            for (int currentTicket = 0; currentTicket < allTickets.Length; currentTicket++)
            {
                string ticket = allTickets[currentTicket];

                if (ticket.Length != 20)
                {
                    result[currentTicket] = "invalid ticket";

                    continue;
                }
                if (jackpotTicket.IsMatch(ticket))
                {
                    result[currentTicket] = $"ticket \"{ticket}\" - 10{ticket[0]} Jackpot!";

                    continue;
                }

                string leftHalf = ticket.Substring(0, 10);
                string rightHalf = ticket.Substring(10, 10);

                if (!winningTicket.IsMatch(leftHalf) || !winningTicket.IsMatch(rightHalf))
                {
                    result[currentTicket] = $"ticket \"{ticket}\" - no match";
                    continue;
                }

                Match leftMatch = winningTicket.Match(leftHalf);
                Match rightMatch = winningTicket.Match(rightHalf);

                leftHalf = leftMatch.Groups[1].ToString();
                rightHalf = rightMatch.Groups[1].ToString();

                //if (leftHalf == rightHalf)
                //{
                //    result[currentTicket] = $"ticket \"{ticket}\" - {leftHalf.Length}{leftHalf[0]}";
                //}
                if (leftHalf[0] == rightHalf[0] && leftHalf.Length <= rightHalf.Length)
                {
                    result[currentTicket] = $"ticket \"{ticket}\" - {leftHalf.Length}{leftHalf[0]}";
                }
                else if (leftHalf[0] == rightHalf[0] && leftHalf.Length > rightHalf.Length)
                {
                    result[currentTicket] = $"ticket \"{ticket}\" - {rightHalf.Length}{leftHalf[0]}";
                }
            }

            for (int currTicket = 0; currTicket < result.Length; currTicket++)
            {
                Console.WriteLine(result[currTicket]);
            }
        }
    }
}
