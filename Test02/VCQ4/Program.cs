using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *******************************************************
 * 
 * Question 4                            
 * Any kind of loop                            
 * Executable - Question4C                  
 * Name - Mohammed Juned Ahmed
 * Marks - 12                              
 * Print the sum of the squares and the average of the 
 * squares. The program prompts for the target square
 * and then prompts the user for as many values as the sum
 * of the squares to JUST exceeds the target value.
 *
 * the square of a number can be obtained by multiplying
 * the number by itself i.e. value * value
 *
 ******************************************************** */
namespace VCQ4
{
    class Program
    {
        static void Main(string[] args)
        {
            int value, sumOfSquares = 0;
            Console.Write("enter the target sum: ");
            int sum = Convert.ToInt32(Console.ReadLine());
            int counter = 0;

            while (sum > sumOfSquares)
            {
                Console.Write("enter the value #{0}: ", counter + 1);
                value = Convert.ToInt32(Console.ReadLine());
                counter++;
                int squares = value * value;
                sumOfSquares += squares;

            }
            double average = (double)sumOfSquares / counter;
            Console.WriteLine("the sum of cubes of {0} numbers is {1} and average is {2:f3}", counter, sumOfSquares, average);
            Console.ReadLine();
        }
    }
}
