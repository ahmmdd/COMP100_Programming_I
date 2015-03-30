using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *******************************************************
 * 
 * Question 4                            
 * Any kind of loop                           
 * Executable - Question4D                  
 * Name -                                 
 * Marks - 12                              
 * Print the sum of the cubes and the average of the 
 * cubes. The program prompts for the number of values
 * to be processed and prompts the user for that many
 * values.
 *
 * the cube of a number can be obtained by multiplying
 * the number by itself 3 times i.e. value * value * value
 *
 ******************************************************** */
namespace VDQ4{
    class Program{
        static void Main(string[] args){
            Console.Write("Enter number of values: ");
            int cubeSum = 0;
            double avg = 0;
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= input; i++){
                Console.Write("Enter value #{0}: ", i);
                int number= Convert.ToInt32(Console.ReadLine());
                int cube = number * number * number;
                cubeSum += cube;
                if (i == input){
                    avg = (double)cubeSum / i;
                }
            }
            Console.WriteLine("For the {0} values the sum of the cubes is {1} and the average is {2:f}", input, cubeSum, avg);
            Console.ReadKey();
        }
    }
}
