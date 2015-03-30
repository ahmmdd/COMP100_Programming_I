using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *******************************************************
 * 
 * Question 3                             
 * for loop                           
 * Executable - Question3D             
 * Name - Mohammed Juned Ahmed
 * Marks - 10                              
 * Print a conversion table of kg to pounds. The program
 * prompts for the end kg the start kg and the decrement
 * value. The table is in decreasing value
 *
 * 1kg = 2.20462 pounds
 *
 ******************************************************** */
namespace VDQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start kg: ");
            double kgStart = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the end kg: ");
            double kgEnd = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the end kg: ");
            double decrement = Convert.ToDouble(Console.ReadLine());
            double pounds;
            Console.WriteLine(" kg\tpounds");
            for (Double i = kgStart; i > kgEnd; i = i - decrement)
            {
                pounds = i * 2.20462;
                Console.WriteLine(" {0}\t{1:f3}", i, pounds);
            }
            Console.ReadLine();
        }
    }
}
