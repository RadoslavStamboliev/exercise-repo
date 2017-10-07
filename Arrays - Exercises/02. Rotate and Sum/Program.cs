using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            int[] result = new int[nums.Length];
            for (int i = 0; i < n; i++)
            {
                rotated(nums);
                resultsum(result, nums);
            }
            Console.WriteLine(string.Join(" ", result));
        }
        private static void rotated(int[] nums)
        {
            var value = nums[nums.Length - 1];
            for (int site = nums.Length - 1; site > 0; site--)
            {
                nums[site] = nums[site - 1];
            }
            nums[0] = value;
            return;
        }
        private static void resultsum(int[] result, int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = result[i] + nums[i];
            }
        }
    }
}
