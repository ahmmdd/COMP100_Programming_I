using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *******************************************************
 * 
 * Question 3                             
 * for loop                           
 * Executable - Question3B             
 * Name - Mohammed Juned Ahmed
 * Marks - 10                              
 * Print a conversion table of kg to pounds. The program
 * prompts for the start kg and the end kg. The table is
 * increments of 2
 *
 * 1kg = 2.20462 pounds
 *
 ******************************************************** */
namespace VBQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start kg: ");
            double kgStart = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the end kg: ");
            double kgEnd = Convert.ToDouble(Console.ReadLine());
            double pounds;
            Console.WriteLine(" kg\tpounds");
            for (Double i = kgStart; i <= kgEnd; i = i + 2)
            {
                pounds = i * 2.20462;
                Console.WriteLine(" {0}\t{1:f3}", i, pounds);
            }
            Console.ReadLine();
        }
    }
}
