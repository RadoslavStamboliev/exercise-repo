using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Nacepin
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal priceUs = decimal.Parse(Console.ReadLine());
            decimal weightUs = decimal.Parse(Console.ReadLine());
            decimal priceUk = decimal.Parse(Console.ReadLine());
            decimal weightUk = decimal.Parse(Console.ReadLine());
            decimal priceChinee = decimal.Parse(Console.ReadLine());
            decimal weihgtChinese = decimal.Parse(Console.ReadLine());
            decimal usStore = priceUs / 0.58m;
            decimal resultUs = usStore / weightUs;
            decimal ukStore = priceUk / 0.41m;
            decimal resultUk = ukStore / weightUk;
            decimal chiseStore = priceChinee * 0.27m;
            decimal resultChise = (chiseStore / weihgtChinese);
            decimal min = Math.Min(Math.Min(resultUs, resultUk), resultChise);
            decimal max = Math.Max(Math.Max(resultUs, resultUk), resultChise);
            decimal difference = Math.Abs(max - min);
            if (resultUs < resultUk && resultUs < resultChise)
            {
                Console.WriteLine("US store. {0:F2} lv/kg", min);
                Console.WriteLine("Difference {0:F2} lv/kg", difference);
            }
            else if (resultUk < resultUs && resultUk < resultChise)
            {

                Console.WriteLine("UK store. {0:F2} lv/kg", min);
                Console.WriteLine("Difference {0:F2} lv/kg", difference);
            }
            else if (resultChise < resultUk && resultChise < resultUs)
            {

                Console.WriteLine("Chinese store. {0:F2} lv/kg", min);
                Console.WriteLine("Difference {0:F2} lv/kg", difference);
            }
        }
    }
}
