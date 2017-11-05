using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var badwords = Console.ReadLine().Split(',', ' ').Where(w => w.Length > 0).ToArray();
            var text = Console.ReadLine();

            foreach (var badword in badwords)
            {
                var replacement = new string('*',badword.Length);
                text = text.Replace(badword, replacement);
            }
            Console.WriteLine(text);
        }
    }
}
