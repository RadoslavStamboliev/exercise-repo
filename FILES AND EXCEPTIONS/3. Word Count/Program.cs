using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _3.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("Input.txt").ToLower()
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' },StringSplitOptions.RemoveEmptyEntries);
            var wordCount=new Dictionary<string,int>();
            foreach (string word in words)
            {
                wordCount[word]=0;
            }
            foreach (string word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
               
            }
            foreach (var word in wordCount.OrderByDescending(x=>x.Value))
            {
                File.AppendAllText(@"Output.txt",$"{word.Key} - {word.Value}{Environment.NewLine}");
            }
        }
    }
}
