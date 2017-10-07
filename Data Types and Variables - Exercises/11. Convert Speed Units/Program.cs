using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float totalSeconds = hours * 3600 + minutes * 60 + seconds;
            float totalHours = hours + minutes / 60 + seconds / 3600;
            Console.WriteLine(meters / totalSeconds);
            Console.WriteLine(meters / 1000 / totalHours);
            Console.WriteLine(meters/1609/totalHours);
           
        }
    }
}
