using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allTickets = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string winningTicket = (@"(\$){6,}|(@){6,}|(\^){6,}|(#){6,}");
            string jackpotTicket = (@"(\$){20}|(@){20}|(\^){20}|(#){20}");

            foreach (var ticket in allTickets)
            {
                bool isMatch = false;
                if (ticket.Length != 20)
                {
                    Console.WriteLine($"invalid ticket");
                    isMatch = true;
                }
                else
                {
                    if (Regex.IsMatch(ticket, jackpotTicket))
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {ticket.Length / 2}{ticket[0]} Jackpot!");
                        isMatch = true;
                    }
                    else
                    {
                        string firstHalf = ticket.Substring(0, 10);
                        string secondHalf = ticket.Substring(10, 10);
                        string firstMatch = Regex.Match(firstHalf, winningTicket).ToString();
                        string secondMatch = Regex.Match(secondHalf, winningTicket).ToString();
                        if (Regex.IsMatch(firstHalf, winningTicket) && Regex.IsMatch(secondHalf, winningTicket))
                        {
                            if (firstMatch.Length > secondMatch.Length)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {secondMatch.Length}{firstMatch[0]}");
                                isMatch = true;
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {firstMatch.Length}{firstMatch[0]}");
                                isMatch = true;
                            }
                        }
                    }
                }
                if (!isMatch)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
    }
}
