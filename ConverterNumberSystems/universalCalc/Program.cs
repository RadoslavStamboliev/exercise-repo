using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universalCalc
{
    class Program
    {
        public string BinToDeci(string value)
        {
            char[] characters = value.ToCharArray();
            int streak = (characters.Length - 1);
            double result1 = 0;

            for (int i = 0; i < characters.Length; i++)
            {
                int number = Convert.ToInt16(characters[i].ToString());
                result1 += number * (Math.Pow(2, streak));
                streak--;
            }
            return result1.ToString();
        }
        static void Main(string[] args)
        {

            BinToDeci();
        }

        private static void BinToDeci()
        {
            throw new NotImplementedException();
        }
    }
}
