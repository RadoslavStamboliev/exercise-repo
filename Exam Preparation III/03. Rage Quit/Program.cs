using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
       
            string pattern = @"(\D+)(\d+)";
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            foreach (Match m in Regex.Matches(input, pattern))
            {
                string word = m.Groups[1].Value.ToUpper();
                int count = int.Parse(m.Groups[2].Value);
                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }
            int uniqueChars = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueChars}");
            Console.WriteLine(result);

            //string input = Console.ReadLine();

            //StringBuilder word = new StringBuilder();
            //StringBuilder count = new StringBuilder();
            //StringBuilder result = new StringBuilder();
            //var inDigits = false;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    char ch = Char.ToUpper(input[i]);
            //    if (inDigits)
            //    {
            //        // Scan for digits
            //        if (Char.IsDigit(ch))
            //        {
            //            count.Append(ch);
            //        }
            //        else
            //        {
            //            // word + count found
            //            for (int c = 0; c < int.Parse(count.ToString()); c++)
            //                result.Append(word);
            //            inDigits = false;
            //            word.Clear();
            //            word.Append(ch);
            //        }
            //    }
            //    else
            //    {
            //        // Scan for letters
            //        if (!Char.IsDigit(ch))
            //        {
            //            word.Append(ch);
            //        }
            //        else
            //        {
            //            // digit found
            //            inDigits = true;
            //            count.Clear();
            //            count.Append(ch);
            //        }
            //    }
            //}

            //for (int c = 0; c < int.Parse(count.ToString()); c++)
            //    result.Append(word);


            //Dictionary<char, bool> charOccurs = new Dictionary<char, bool>();
            //foreach (var ch in result.ToString())
            //{
            //    charOccurs[ch] = true;
            //}
            //var uniqueChars = charOccurs.Keys.Count;

            //Console.WriteLine($"Unique symbols used: {uniqueChars}");
            //Console.WriteLine(result.ToString());


        }
    }
}
