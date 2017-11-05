using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^\d+([a-zA-Z]+)[^a-zA-Z]*$");
            string command = Console.ReadLine().Trim();
            while (command != "Over!")
            {
                int charNumber = int.Parse(Console.ReadLine());
                if (regex.IsMatch(command))
                {
                    string message = regex.Match(command).Groups[1].ToString();
                    if (message.Length == charNumber)
                    {
                        MatchCollection digits = Regex.Matches(command.Trim(), @"\d");

                        StringBuilder sb=new StringBuilder();

                        foreach (Match digitMatch in digits)
                        {
                            int index = int.Parse(digitMatch.Value);
                            if (index>message.Length-1)
                            {
                                sb.Append(" ");
                            }
                            else
                            {
                                sb.Append(message[index]);
                            }
                        }
                        Console.WriteLine($"{message} == {sb}");
                    }
                }
                command = Console.ReadLine().Trim();
            }
        }
    }
}
