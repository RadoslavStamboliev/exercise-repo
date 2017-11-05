using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                decimal price = ReadOrderAndCalcPrice();
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");

            //var N = int.Parse(Console.ReadLine());
            //var coffeePrices = new List<decimal>();
            //for (int i = 0; i < N; i++)
            //{
            //    var pricePerCapsule = decimal.Parse(Console.ReadLine());
            //    var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            //    var capsulesCount = decimal.Parse(Console.ReadLine());
            //    var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

            //    decimal price = ((daysInMonth * capsulesCount) * pricePerCapsule);
            //    coffeePrices.Add(price);
            //}
            //foreach (var price in coffeePrices)
            //{
            //    Console.WriteLine($"The price for the coffee is: ${price:f2}");
            //}
            //Console.WriteLine($"Total: ${coffeePrices.Sum():f2}");
        }

        static decimal ReadOrderAndCalcPrice()
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            string dateString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateString,"d/M/yyyy",CultureInfo.InvariantCulture);
            decimal daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            decimal capsulesCount = decimal.Parse(Console.ReadLine());
            decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;
            Console.WriteLine($"The price for the coffee is: ${price:f2}");
            return price;
        }
    }
}
