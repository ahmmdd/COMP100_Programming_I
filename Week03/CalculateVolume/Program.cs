using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int length, width, height;
            //processing
            //output
            int volume;
            //algorithm
            //STEP 1 - prompt and accept length, width, and height
            Console.Write("Enter length: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height: ");
            height = Convert.ToInt32(Console.ReadLine());
            //STEP 2 - calculate volume = length * width * height
            volume = length * width * height;
            //STEP 3 - display volume
            Console.WriteLine("Volume will be {0} cubic meters", volume);
            Console.ReadLine();

        }
    }
}
