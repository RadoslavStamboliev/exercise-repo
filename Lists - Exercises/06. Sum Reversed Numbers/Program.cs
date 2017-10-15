using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sum = 0;
            int reverse = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                reverse = 0;
                while (nums[i] > 0)
                {
                    int rem = nums[i] % 10;
                    reverse = (reverse * 10) + rem;
                    nums[i] = nums[i] / 10;
                }
                sum += reverse;
            }
            Console.WriteLine(sum);
        }
    }
}
