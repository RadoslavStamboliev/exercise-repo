using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] secondArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
          
            //int leftCount = FindMaxCommonItems(firstArray, secondArray);
            //Array.Reverse(firstArray);
            //int rightCount = FindMaxCommonItems(firstArray, secondArray);
            //Console.WriteLine($"{Math.Max(leftCount,rightCount)}");
           
            largestCommonEnd(firstArray, secondArray);
        }
        //static  int FindMaxCommonItems(string[] firstArray,string[] secondArray)
        //{
        //    int count = 0;
        //    int lenght = Math.Min(firstArray.Length, secondArray.Length);
        //    for (int i = 0; i < lenght; i++)
        //    {
        //        if (firstArray[i] == secondArray[i])
        //        {
        //            count++;
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //    return count;
        //}
        static void largestCommonEnd(string[] first, string[] second)
        {
            int rightCount = 0;
            int leftCount = 0;
            while (rightCount < first.Length && rightCount < second.Length)
            {
                if (first[first.Length - rightCount - 1] == second[second.Length - rightCount - 1])
                {
                    rightCount++;
                }
                else break;
            }

            while (leftCount < first.Length && leftCount < second.Length)
            {
                if (first[leftCount] == second[leftCount])
                {
                    leftCount++;
                }
                else break;
            }

            if (rightCount > leftCount)
            {
                Console.WriteLine(rightCount);
            }
            else
            {
                Console.WriteLine(leftCount);
            }
        }
    }
}
