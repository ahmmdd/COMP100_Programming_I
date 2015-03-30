using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *******************************************************
 * 
 * Question 2
 * while loop
 * Executable - Question2D
 * Name - Mohammed Juned Ahmed
 * Marks - 7
 * Print the multiples from a start to an end in ascending 
 * order
 *
 * 
 ******************************************************** */
namespace VDQ2{
    class Program{
        static void Main(string[] args){

            int startNumber, endNumber, multiple;
            Console.Write("Enter the start number: ");
            startNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the end number: ");
            endNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the multiple: ");
            multiple = Convert.ToInt32(Console.ReadLine());

            while (startNumber < endNumber)
            {
                if (startNumber % multiple == 0)
                {
                    Console.WriteLine("{0}", startNumber);
                }
                startNumber++;
            }
            Console.ReadKey();
        
        }
    }
}
