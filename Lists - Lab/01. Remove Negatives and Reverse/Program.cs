using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            string[] inputArr = inputStr.Split(' ');
            List<int> inputInt = new List<int>();
            List<int> newIntList = new List<int>();
            for (int i = 0; i < inputArr.Length; i++)
            {
                inputInt.Add(int.Parse(inputArr[i]));
            }

            for (int i = 0; i < inputInt.Count; i++)
            {
                if (inputInt[i] > 0)
                {
                    newIntList.Add(inputInt[i]);
                }
            }

            if (newIntList.Any())
            {
                newIntList.Reverse();
                foreach (var item in newIntList)
                {
                    Console.WriteLine(item);
                }

            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
