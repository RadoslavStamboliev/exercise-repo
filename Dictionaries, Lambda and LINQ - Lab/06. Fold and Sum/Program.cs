using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = nums.Length / 4;
            int[] row1LeftPart = nums.Take(k).Reverse().ToArray();
            int[] row1RightPart = nums.Reverse().Take(k).ToArray();
            int[] row1 = row1LeftPart.Concat(row1RightPart).ToArray();
            int[] row2 = nums.Skip(k).Take(2 * k).ToArray();
            var sumNums = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ",sumNums));
        }
    }
}
