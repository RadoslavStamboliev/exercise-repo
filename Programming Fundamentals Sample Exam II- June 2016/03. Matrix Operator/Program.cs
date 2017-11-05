using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Matrix_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> matrix = GetMatrix();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var data = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = data[0];

                if (command == "remove")
                {
                    matrix = RemoveElements(matrix, data);
                }
                else if (command == "swap")
                {
                    matrix = SwapRows(matrix, data);
                }
                else if (command=="insert")
                {
                    matrix = InsertElementInRow(matrix, data);
                }
            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(List<List<int>> matrix)
        {
            for (int row = 0; row < matrix.Count; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }
        }

        private static List<List<int>> InsertElementInRow(List<List<int>> matrix, string[] data)
        {
            int row = int.Parse(data[1]);
            int element = int.Parse(data[2]);
            bool isValidIndex = row >= 0 && row < matrix.Count;
            if (isValidIndex)
            {
                List<int> elements = matrix[row];
                elements.Insert(0,element);
                matrix[row] = elements; 

            }
            return matrix;
        }

        private static List<List<int>> SwapRows(List<List<int>> matrix, string[] data)
        {
            int row1 = int.Parse(data[1]);
            int row2 = int.Parse(data[2]);
            bool isValidIndex = row1 >= 0 && row1 < matrix.Count && row2 >= 0 && row2 < matrix.Count;
            if (isValidIndex)
            {
                List<int> elementsRow1 = matrix[row1];
                List<int> elementsRow2 = matrix[row2];
                matrix[row1] = elementsRow2;
                matrix[row2] = elementsRow1;
            }
            return matrix;

        }

        private static List<List<int>> RemoveElements(List<List<int>> matrix, string[] data)
        {
            string type = data[1];
            string rowCol = data[2];
            int index = int.Parse(data[3]);
            bool isValidRowIndex = index >= 0 && index <= matrix.Count;
            if (rowCol == "row" && isValidRowIndex)
            {
                List<int> elements = matrix[index];
                if (type == "positive")
                {
                    elements.RemoveAll(x => x >= 0);
                }
                else if (type == "negative")
                {
                    elements.RemoveAll(x => x < 0);
                }
                else if (type == "odd")
                {
                    elements.RemoveAll(x => x % 2 != 0);
                }
                else if (type == "even")
                {
                    elements.RemoveAll(x => x % 2 == 0);
                }
                matrix[index] = elements;
            }
            else if (rowCol == "col")
            {
                for (int row = 0; row < matrix.Count; row++)
                {
                    bool isValidColIndex = index >= 0 && index < matrix[row].Count;
                    if (isValidColIndex)
                    {
                        List<int> elements = matrix[row];
                        if (type == "positive" && elements[index] >= 0)
                        {
                            elements.RemoveAt(index);
                        }
                        else if (type == "negative" && elements[index] < 0)
                        {
                            elements.RemoveAt(index);
                        }
                        else if (type == "odd" && elements[index] % 2 != 0)
                        {
                            elements.RemoveAt(index);
                        }
                        else if (type == "even" && elements[index] % 2 == 0)
                        {
                            elements.RemoveAt(index);
                        }
                        matrix[row] = elements;
                    }
                }
            }
            return matrix;
        }

        private static List<List<int>> GetMatrix()
        {
            int rows = int.Parse(Console.ReadLine());
            List<List<int>> matrix = new List<List<int>>();
            for (int row = 0; row < rows; row++)
            {
                List<int> elements = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();
                matrix.Add(elements);
            }
            return matrix;
        }
    }
}
