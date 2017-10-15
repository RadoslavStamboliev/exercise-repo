using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split();
            var dict = new Dictionary<string, string>();
            while (commands[0] != "END")
            {
                if (commands[0] == "A")
                {
                    AddInPhonebook(dict, commands);
                }
                else if (commands[0] == "S")
                {
                    PrintSearchedName(dict, commands);
                }
                else if (commands[0] == "ListAll")
                {
                    PrintListsAll(dict);
                }
                commands = Console.ReadLine().Split();
            }

        }
        static void PrintListsAll(Dictionary<string, string> dict)
        {
            foreach (var pair in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
        static void AddInPhonebook(Dictionary<string, string> dict, string[] commands)
        {
            dict[commands[1]] = commands[2];
        }
        static void PrintSearchedName(Dictionary<string, string> dict, string[] commands)
        {
            string searchedName = commands[1];
            if (dict.ContainsKey(searchedName))
            {
                Console.WriteLine($"{searchedName} -> {dict[searchedName]}");
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", commands[1]);
            }
        }
    }
}
