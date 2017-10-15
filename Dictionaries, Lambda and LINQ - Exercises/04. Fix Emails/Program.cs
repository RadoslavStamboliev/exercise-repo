using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string name = Console.ReadLine();
            string[] domains = { ".us", ".uk" };
            while (!name.Equals("stop"))
            {
                string email = Console.ReadLine();
                emails.Add(name, email);
                name = Console.ReadLine();
            }
            RemoveEmailsByDomain(emails, domains);
            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
        static void RemoveEmailsByDomain(Dictionary<string,string>emails,string[] domains)
        {
            foreach (var domain in domains)
            {
                var filtredEmails = emails.Where(x => x.Value.EndsWith(domain)).ToList();
                foreach (var userEntry in filtredEmails)
                {
                    emails.Remove(userEntry.Key);
                }
            }
        }
    }
}
