using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double suitablePrice = 1;
            double priceOfThePackage = 1;
            double discount = 1;
            string hall = "";
            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                if (groupSize > 100 && groupSize <= 120)
                {
                    hall = "Great Hall";
                    switch (package)
                    {
                        case "Normal":
                            discount = 0.95;
                            priceOfThePackage = 500;
                            break;
                        case "Gold":
                            discount = 0.90;
                            priceOfThePackage = 750;
                            break;
                        case "Platinum":
                            discount = 0.85;
                            priceOfThePackage = 1000;
                            break;
                    }
                    suitablePrice = (7500 + priceOfThePackage) * discount;
                }
                else if (groupSize>50&&groupSize<=100)
                {
                    hall = "Terrace";
                    switch (package)
                    {
                        case "Normal":
                            discount = 0.95;
                            priceOfThePackage = 500;
                            break;
                        case "Gold":
                            discount = 0.90;
                            priceOfThePackage = 750;
                            break;
                        case "Platinum":
                            discount = 0.85;
                            priceOfThePackage = 1000;
                            break;
                    }
                    suitablePrice = (5000 + priceOfThePackage) * discount;
                }
                else if (groupSize<=50)
                {
                    hall = "Small Hall";
                    switch (package)
                    {
                        case "Normal":
                            discount = 0.95;
                            priceOfThePackage = 500;
                            break;
                        case "Gold":
                            discount = 0.90;
                            priceOfThePackage = 750;
                            break;
                        case "Platinum":
                            discount = 0.85;
                            priceOfThePackage = 1000;
                            break;
                    }
                    suitablePrice = (2500 + priceOfThePackage) * discount;
                }
                double pricePerPerson = suitablePrice / groupSize;
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
        }
    }
}
