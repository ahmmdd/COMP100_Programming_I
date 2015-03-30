using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *******************************************************
 * 
 * Question 3                             
 * for loop                           
 * Executable - Question3C             
 * Name - Mohammed Juned Ahmed
 * Marks - 10                              
 * Print a conversion table of km to miles. The program
 * prompts for the end km, the start km and the decrement
 * value. The table is is in decreasing km value
 *
 * 1km = 0.621371 miles
 *
 ******************************************************** */
namespace VCQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start km: ");
            double kmStart = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the end km: ");
            double kmEnd = Convert.ToDouble(Console.ReadLine());
            double miles;
            Console.WriteLine(" km\tmiles");
            for (Double i = kmStart; i < kmEnd; i = i + 5)
            {
                miles = i * 0.621371;
                Console.WriteLine(" {0}\t{1:f3}", i, miles);
            }
            Console.ReadLine();
        }
    }
}
