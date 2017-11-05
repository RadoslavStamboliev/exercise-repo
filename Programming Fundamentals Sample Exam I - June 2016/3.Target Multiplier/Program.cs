using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Target_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
                }
            }

            var coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var targetRow = coordinates[0];
            var targetCol = coordinates[1];

            int startRow = targetRow - 1;
            int endRow = targetRow + 1;
            int starCol = targetCol - 1;
            int endCol = targetCol + 1;

            int sumofNeighbours = 0;

            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = starCol; col <= endCol; col++)
                {

                    sumofNeighbours += matrix[row, col];
                }
            }

            sumofNeighbours = sumofNeighbours - matrix[targetRow, targetCol];
            int originalValue = matrix[targetRow, targetCol];

            for (int row = startRow; row < endRow + 1; row++)
            {
                for (int col = starCol; col < endCol + 1; col++)
                {
                    if (row == targetRow && col == targetCol)
                    {
                        matrix[row, col] = matrix[row, col] * sumofNeighbours;
                    }
                    else
                    {
                        matrix[row, col] = matrix[row, col] * originalValue;
                    }

                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
