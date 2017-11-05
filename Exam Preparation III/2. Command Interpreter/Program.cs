using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Command_Interpreter
{
    class Program
    {
        static void Main()
        {
            List<string> items = ReadInputItems();

            while (true)
            {
                var commandLine = Console.ReadLine();
                if (commandLine == "end")
                    break;
                ProcessCommand(items, commandLine);
            }

            Console.WriteLine($"[{string.Join(", ", items)}]");
        }

        private static void ProcessCommand(List<string> items, string commandLine)
        {
            var cmdTokens = commandLine.Split(' ');
            var cmdName = cmdTokens[0];
            switch (cmdName)
            {
                case "reverse":
                    ReverseList(items, cmdTokens);
                    break;
                case "sort":
                    SortList(items, cmdTokens);
                    break;
                case "rollLeft":
                    RollLeftList(items, cmdTokens);
                    break;
                case "rollRight":
                    RollRightList(items, cmdTokens);
                    break;
            }
        }

        static void ReverseList(List<string> items, string[] cmdTokens)
        {
            int startIndex = int.Parse(cmdTokens[2]);
            int count = int.Parse(cmdTokens[4]);
            if (IsValidRange(items, startIndex, count))
                ReverseList(items, startIndex, count);
            else
                Console.WriteLine("Invalid input parameters.");
        }

        static bool IsValidRange(List<string> items, int startIndex, int count)
        {
            if (startIndex < 0)
                return false;
            if (startIndex >= items.Count)
                return false;
            if (count < 0)
                return false;
            if (startIndex + count - 1 >= items.Count)
                return false;
            return true;
        }

        static void ReverseList(List<string> items, int startIndex, int count)
        {
            var endIndex = startIndex + count - 1;

            while (startIndex < endIndex)
            {
                var oldValue = items[startIndex];
                items[startIndex] = items[endIndex];
                items[endIndex] = oldValue;
                endIndex--;
                startIndex++;
            }
        }

        static void SortList(List<string> items, string[] cmdTokens)
        {
            int startIndex = int.Parse(cmdTokens[2]);
            int count = int.Parse(cmdTokens[4]);
            if (IsValidRange(items, startIndex, count))
                SortList(items, startIndex, count);
            else
                Console.WriteLine("Invalid input parameters.");
        }

        static void SortList(List<string> items, int startIndex, int count)
        {
            // 10 | 20 30 | 40 50
            //      1  2
            // startIndex = 1;
            // count = 2;

            var leftList = items.Take(startIndex);
            var middleList = items.Skip(startIndex).Take(count).OrderBy(x => x);
            var rightList = items.Skip(startIndex + count);
            var allItems = leftList.Concat(middleList).Concat(rightList);

            var index = 0;
            foreach (var item in allItems.ToList())
            {
                items[index] = item;
                index++;
            }
        }

        static void RollLeftList(List<string> items, string[] cmdTokens)
        {
            int count = int.Parse(cmdTokens[1]);
            if (count >= 0)
                RollListList(items, -count);
            else
                Console.WriteLine("Invalid input parameters.");
        }

        static void RollListList(List<string> items, int count)
        {
            count = count % items.Count;
            var result = new string[items.Count];

            for (int i = 0; i < items.Count; i++)
            {
                var newPos = (i + count) % items.Count;
                if (newPos < 0)
                    newPos += items.Count;
                result[newPos] = items[i];
            }

            var index = 0;
            foreach (var item in result.ToList())
            {
                items[index] = item;
                index++;
            }
        }

        static void RollRightList(List<string> items, string[] cmdTokens)
        {
            int count = int.Parse(cmdTokens[1]);
            if (count >= 0)
                RollListList(items, count);
            else
                Console.WriteLine("Invalid input parameters.");
        }

        static List<string> ReadInputItems()
        {
            List<string> items =
                Console.ReadLine()
                .Split(' ')
                .Where(i => i.Length > 0)
                .ToList();
            return items;
        }
    }
}
