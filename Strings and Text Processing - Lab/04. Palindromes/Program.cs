﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { ',', '!', '?', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();

            foreach (var word in text)
            {
                bool isPalindrome = CheckWord(word);
                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }
            palindromes = palindromes.Distinct().OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ",palindromes));
        }

        private static bool CheckWord(string word)
        {
            var reversed = new string(word.Reverse().ToArray());
            return word == reversed;
        }
        
      //private static bool CheckWord(string word)
      //  {
      //      string reversed = "";

      //      for (int i = word.Length - 1; i >= 0; i--)
      //      {
      //          reversed += word[i];
      //      }

      //      if (reversed == word)
      //      {
      //          return true;
      //      }
      //      else
      //      {
      //          return false;
      //      }
      //  }
        //private static bool isPalindrome1(string s)
        //{
        //    for (int i = 0; i < s.Length/2; i++)
        //    {
        //        if (s[i]!=s[s.Length-i-1])
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
    }
}
