using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPics = long.Parse(Console.ReadLine());
            long filterTimePic = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTimePic = long.Parse(Console.ReadLine());
            long filteredPics = (long)(Math.Ceiling(numberOfPics * filterFactor / 100d));
            long timeToFilterPics = numberOfPics * filterTimePic;
            long timeToUploadPics = filteredPics * uploadTimePic;
            long totalTime = timeToFilterPics + timeToUploadPics;
            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine("{0:d\\:hh\\:mm\\:ss}", time);
        }
    }
}
