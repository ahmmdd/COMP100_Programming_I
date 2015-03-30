using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *******************************************************
 * 
 * Question 4                            
 * Any kind of loop                            
 * Executable - Question4A             
 * Name - Mohammed Juned Ahmed
 * Marks - 12                              
 * Print the sum of the squares and the average of the 
 * squares. The program prompts for the number of values
 * to be processed and prompts the user for that many
 * values.
 *
 * the square of a number can be obtained by multiplying
 * the number by itself i.e. value * value
 *
 ******************************************************** */
namespace VAQ4{
    class Program{
        static void Main(string[] args){
            Double inputNum,squares,squaresSum,average;
            average = 0;
            squaresSum = 0;
            Console.Write("How many number would you like to process? ");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= input; i++){
                Console.Write("Enter value #{0}: ", i);
                inputNum = Convert.ToDouble(Console.ReadLine());
                squares = inputNum * inputNum;
                squaresSum += squares;
                if (i == input){
                    average = squaresSum / i;
                }
            }
            Console.WriteLine("The sum of the squares of the {0} numbers is {1} and the average is {2:f3}", input, squaresSum, average);
            Console.ReadLine();
        }
    }
}
