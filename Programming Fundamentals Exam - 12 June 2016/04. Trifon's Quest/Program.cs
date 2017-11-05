using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trifon_s_Quest
{
    class Program
    {
        static void Main()
        {
            long health = long.Parse(Console.ReadLine());
            char[][] matrix = GetMatrix();
            int[] playerPosition = new int[2];
            int turns = 0;
            for (int col = 0; col < matrix[0].Length; col++)
            {
                if (col % 2 == 0)   // moving down
                    for (int row = 0; row < matrix.Length; row++)
                    {
                        health = UpdateHealth(health, turns, matrix[row][col]);
                        turns = UpdateTurns(turns, matrix[row][col]);
                        if (health <= 0)
                        {
                            playerPosition = new int[] { row, col }; break;
                        }
                    }
                else    // moving up
                    for (int row = matrix.Length - 1; row >= 0; row--)
                    {
                        health = UpdateHealth(health, turns, matrix[row][col]);
                        turns = UpdateTurns(turns, matrix[row][col]);
                        if (health <= 0)
                        {
                            playerPosition = new int[] { row, col }; break;
                        }
                    }
                if (health <= 0) break;
            }
            PrintStats(health, turns, playerPosition);
        }

        private static void PrintStats(long health, int turns, int[] playerPosition)
        {
            if (health > 0)
            {
                Console.WriteLine("Quest completed!");
                Console.WriteLine($"Health: {health}");
                Console.WriteLine($"Turns: {turns}");
            }
            else
                Console.WriteLine("Died at: [{0}]", string.Join(", ", playerPosition));
        }
        private static int UpdateTurns(int turns, char element)
        {
            if (element == 'T') turns += 2;
            turns++;
            return turns;
        }

        private static long UpdateHealth(long health, int turns, char element)
        {
            if (element == 'F') health -= turns / 2;
            else if (element == 'H') health += turns / 3;
            return health;
        }

        private static char[][] GetMatrix()
        {
            int[] dimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = dimensions[0];
            char[][] matrix = new char[rows][];
            for (int row = 0; row < rows; row++)
                matrix[row] = Console.ReadLine().ToCharArray();
            return matrix;
        }
    }
}
