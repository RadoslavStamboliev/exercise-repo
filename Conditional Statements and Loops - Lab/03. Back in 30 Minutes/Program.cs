﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes= int.Parse(Console.ReadLine());

            minutes = minutes + 30;
            if (minutes>59)
            {
                hours++;
                if (hours > 23)
                {
                    hours = 0;
                }
                minutes = minutes - 60;
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}