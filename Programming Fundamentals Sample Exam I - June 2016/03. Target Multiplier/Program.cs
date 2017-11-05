using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Target_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            long[][] matrix = GetMatrix();
            int[] target = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            matrix = GetModifiedMatrix(matrix, target);
            Print(matrix);
        }

        private static long[][] GetModifiedMatrix(long[][] matrix, int[] target)
        {
            long targetCell = matrix[target[0]][target[1]];
            long sumNeibouringCells = GetSumCells(matrix, target);
            for (int row = target[0] - 1; row <= target[0] + 1; row++)
            {
                for (int col = target[1] - 1; col <= target[1] + 1; col++)
                {
                    bool isTargetCell = row == target[0] && col == target[1];
                    if (!isTargetCell)
                    {
                        matrix[row][col] *= targetCell;
                    }
                }
            }
            matrix[target[0]][target[1]] *= sumNeibouringCells;
            return matrix;
        }

        private static long GetSumCells(long[][] matrix, int[] target)
        {
            long sumCells = -matrix[target[0]][target[1]];
            for (int row = target[0] - 1; row <= target[0] + 1; row++)
            {
                for (int col = target[1] - 1; col <= target[1] + 1; col++)
                {
                    sumCells += matrix[row][col];
                }
            }
            return sumCells;
        }

        private static long[][] GetMatrix()
        {
            int[] matrixDimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = matrixDimensions[0];
            long[][] matrix = new long[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse).ToArray();
            }
            return matrix;
        }
        private static void Print(long[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }
        }

    }
}
