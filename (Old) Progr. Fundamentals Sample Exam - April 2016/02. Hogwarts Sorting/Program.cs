using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hogwarts_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Gryffindor = 0;
            int Slytherin = 0;
            int Ravenclaw = 0;
            int Hufflepuff = 0;

            string student = "";
            string initials = "";
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                string[] names = Console.ReadLine().Split(' ');
                string firstName = names[0];
                string lastName = names[1];
                for (int j = 0; j < firstName.Length; j++)
                {
                    sum += firstName[j];
                }
                for (int j = 0; j < lastName.Length; j++)
                {
                    sum += lastName[j];
                }
                string facultyNumber = string.Format("{0}{1}{2}", sum, firstName[0], lastName[0]);
                int reminder = sum % 4;

                switch (reminder)
                {
                    case 0:
                        Gryffindor++;
                        Console.WriteLine("Gryffindor {0}", facultyNumber);
                        break;
                    case 1:
                        Slytherin++;
                        Console.WriteLine("Slytherin {0}", facultyNumber);
                        break;
                    case 2:
                        Ravenclaw++;
                        Console.WriteLine("Ravenclaw {0}", facultyNumber);
                        break;
                    case 3:
                        Hufflepuff++;
                        Console.WriteLine("Hufflepuff {0}", facultyNumber);
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Gryffindor: {0}", Gryffindor);
            Console.WriteLine("Slytherin: {0}", Slytherin);
            Console.WriteLine("Ravenclaw: {0}", Ravenclaw);
            Console.WriteLine("Hufflepuff: {0}", Hufflepuff);
        }
    }
}
