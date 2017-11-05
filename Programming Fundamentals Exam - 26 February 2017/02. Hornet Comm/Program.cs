using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> messagesCode = new List<string>();
            List<string> messagesMessage = new List<string>();
            List<string> broadcastsFrequqncy = new List<string>();
            List<string> broadcastCode = new List<string>();
            int messagesCount = 0;
            int broadcatstCount = 0;
            string messagePattern = @"^[0-9]+ <-> [a-zA-Z0-9]+$";
            string broadcastPattern = @"^[^0-9]+ <-> [a-zA-Z0-9]+$";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Hornet is Green")
                {
                    break;
                }
                if (Regex.IsMatch(input, messagePattern))
                {
                    string[] data = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                    string recipient = string.Join("", data[0].Reverse());
                    string message = data[1];
                    messagesCode.Add(recipient);
                    messagesMessage.Add(message);
                    messagesCount++;
                }
                if (Regex.IsMatch(input, broadcastPattern))
                {
                    string[] data = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                    string message = data[0];
                    string frequency = data[1];
                    StringBuilder frequencyToAdd = new StringBuilder();
                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (frequency[i] + 0 >= 97 && frequency[i] + 0 <= 122)
                        {
                            frequencyToAdd.Append(frequency[i].ToString().ToUpper());
                        }
                        else
                        {
                            frequencyToAdd.Append(frequency[i].ToString().ToLower());
                        }

                    }
                    broadcastCode.Add(message);
                    broadcastsFrequqncy.Add(frequencyToAdd.ToString());
                    broadcatstCount++;
                }

            }
            Console.WriteLine("Broadcasts:");
            if (broadcatstCount == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < broadcastsFrequqncy.Count(); i++)
                {
                    Console.WriteLine($"{broadcastsFrequqncy[i]} -> {broadcastCode[i]}");
                }
            }
            Console.WriteLine("Messages:");
            if (messagesCount == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < messagesMessage.Count(); i++)
                {
                    Console.WriteLine($"{messagesCode[i]} -> {messagesMessage[i]}");

                }
            }
        }
    }
}
