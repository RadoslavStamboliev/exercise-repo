using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] nums = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();
            int[] count = new int[65536];
            foreach (ushort num in nums)
            {
                count[num]++;
            }
            int maxValue = count.Max();
            for (int i = 0; i < nums.Length; i++)
            {
                if (count[nums[i]]==maxValue)
                {
                    Console.WriteLine(nums[i]);
                    return;
                }
            }
        }
    }
}
