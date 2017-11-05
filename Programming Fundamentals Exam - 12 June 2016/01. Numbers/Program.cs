using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] nums = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long averageNum = nums.Sum() / nums.Length;
            var result1 = nums.OrderByDescending(a => a);
            var str = result1.Take(5).Where(num => num > averageNum).ToArray();
            bool isTrue = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == averageNum)
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                }
            }
            if (isTrue)
            {
                Console.WriteLine("No");

            }
            else
            {
                Console.WriteLine(string.Join(" ", str));
            }
        }
    }
}
