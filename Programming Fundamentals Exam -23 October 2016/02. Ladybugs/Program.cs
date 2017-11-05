using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                var indexes = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();
                int[] field = new int[n];
                for (int i = 0; i < n; i++)
                {
                    field[i] = 0;
                }
                foreach (var position in indexes)
                {
                    if (position < field.Length && position >= 0)
                    {
                        field[position] = 1;
                    }
                }
                string flight = Console.ReadLine();
                while (flight != "end")
                {
                    var commands = flight.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    int indexOfLadybug = int.Parse(commands[0]);
                    string direction = commands[1];
                    int flightLength = (int.Parse(commands[2]));
                    if (flightLength < 0)
                    {
                        if (direction == "left")
                        {
                            direction = "right";
                            flightLength *= (-1);
                        }
                        else
                        {
                            direction = "left";
                            flightLength *= (-1);
                        }
                    }
                    if (indexOfLadybug >= 0 && indexOfLadybug < field.Length && flightLength != 0)
                    {
                        if (field[indexOfLadybug] != 0)
                        {
                            switch (direction)
                            {
                                case "right":
                                    int initialIndex = indexOfLadybug;
                                    while (indexOfLadybug + flightLength < field.Length)
                                    {
                                        if (field[indexOfLadybug + flightLength] == 1)
                                        {
                                            indexOfLadybug += flightLength;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    if (indexOfLadybug + flightLength >= field.Length)
                                    {
                                        field[initialIndex] = 0;
                                    }
                                    else
                                    {
                                        field[initialIndex] = 0;
                                        field[indexOfLadybug + flightLength] = 1;
                                    }
                                    break;
                                case "left":
                                    int initialIndexLeft = indexOfLadybug;
                                    while (indexOfLadybug - flightLength >= 0)
                                    {
                                        if (field[indexOfLadybug - flightLength] == 1)
                                        {
                                            indexOfLadybug -= flightLength;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    if (indexOfLadybug - flightLength < 0)
                                    {
                                        field[initialIndexLeft] = 0;
                                    }
                                    else
                                    {
                                        field[initialIndexLeft] = 0;
                                        field[indexOfLadybug - flightLength] = 1;
                                    }
                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                    flight = Console.ReadLine();
                }
                StringBuilder result = new StringBuilder();
                foreach (var ladybug in field)
                {
                    result.Append(ladybug.ToString());
                    result.Append(" ");
                }
                result.Remove(result.Length - 1, 1);
                Console.WriteLine(result);
            }
        }
    }
}
