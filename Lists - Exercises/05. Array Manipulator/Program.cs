using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "print")
            {
                var commandArrgs = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
               
                if (commandArrgs[0]=="add")
                {
                    numbers.Insert(int.Parse(commandArrgs[1]), int.Parse(commandArrgs[2]));
                }
                else if (commandArrgs[0]=="addMany")
                {
                    numbers.InsertRange(int.Parse(commandArrgs[1]),commandArrgs.Skip(2).Select(int.Parse).ToList());
                }
                else if (commandArrgs[0] == "contains")
                {
                    int number = int.Parse(commandArrgs[1]);
                    Console.WriteLine(numbers.IndexOf(number));
                    //if (numbers.Contains(number))
                    //{
                    //    Console.WriteLine(numbers.IndexOf(number));
                    //}
                    //else
                    //{
                    //    Console.WriteLine(-1);
                    //}
                }
                else if (commandArrgs[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(commandArrgs[1]));
                }
                else if (commandArrgs[0] == "shift")
                {
                    int number = int.Parse(commandArrgs[1]);
                    number = number % numbers.Count;
                    //var reminder = numbers.Take(number).ToList();
                    //numbers.RemoveRange(0, number);
                    //numbers.AddRange(reminder);
                    for (int i = 0; i < number; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }
                else if (commandArrgs[0] == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count-1; i++)
                    {
                        var sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ",numbers)}]");
        }
    }
}
