using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *******************************************************
 * 
 * Question 4                            
 * Any kind of loop                            
 * Executable - Question4B             
 * Name - Mohammed Juned Ahmed
 * Marks - 12                              
 * Print the sum of the cubes and the average of the 
 * cubes. The program prompts for the target cube
 * and then prompts the user for as many values as the sum
 * of the cubes to JUST exceeds the target value.
 *
 * the cube of a number can be obtained by multiplying
 * the number by itself 3 times i.e. value * value * value
 *
 ******************************************************** */
namespace VBQ4{
    class Program{
        static void Main(string[] args){

            int value, sumOfCubes=0;
            Console.Write("enter the target sum: ");
            int sum = Convert.ToInt32(Console.ReadLine());
            int counter = 0;

            while (sum > sumOfCubes){
                Console.Write("enter the value #{0}: ", counter+1);
                value = Convert.ToInt32(Console.ReadLine());
                counter++;
                int cubes = value * value * value;
                sumOfCubes += cubes;
                //if()
            }
            double average = (double)sumOfCubes / counter;
            Console.WriteLine("the sum of cubes of {0} numbers is {1} and average is {2:f3}",counter,sumOfCubes,average);
            Console.ReadLine();
        }
    }
}
