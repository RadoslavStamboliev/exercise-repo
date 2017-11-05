using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (first.Length>second.Length)
            {
                second = second.PadLeft(first.Length, '0');
            }
            else
            {
                first = first.PadLeft(second.Length, '0');
            }
            StringBuilder sb = new StringBuilder();
            var sum = 0;
            var number = 0;
            var reminder = 0;

            for (int i = first.Length-1; i >= 0; i--)
            {
                sum = first[i] - 48 + second[i] - 48+reminder;
                number = sum % 10;
                sb.Append(number);
                reminder = sum / 10;
                
                if (i==0&&reminder>0)
                {
                    sb.Append(reminder);
                }
            }
            Console.WriteLine(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
            //string firstNumber = Console.ReadLine().TrimStart(new char[] {'0'});
            //string secondNumber = Console.ReadLine().TrimStart(new char[]{'0'});
            //if (firstNumber.Length >secondNumber.Length)
            //{
            //    secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
            //}
            //else
            //{
            //    firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
            //}
            //int sum = 0;
            //int numberInMind = 0;
            //int remainder = 0;
            //StringBuilder result=new StringBuilder();
            //for (int i = firstNumber.Length-1; i >=0; i--)
            //{
            //    sum = (int) (int.Parse(firstNumber[i].ToString()) + int.Parse(secondNumber[i].ToString()) +
            //                 numberInMind);
            //    numberInMind = (int)(sum / 10);
            //    remainder = (int)(sum % 10);
            //    result.Append(remainder);
            //    if (i==0&&numberInMind!=0)
            //    {
            //        result.Append(numberInMind);
            //    }
            //}
            //char[] resultToChar = result.ToString().ToCharArray();
            //Array.Reverse(resultToChar);
            //Console.WriteLine(new string(resultToChar));
        }
    }
}
