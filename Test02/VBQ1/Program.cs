using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *******************************************************
 *
 * Question 1                             
 * do-while loop                           
 * Executable - Question1B             
 * Name - Mohammed Juned Ahmed
 * Marks - 6                              
 * Print the numbers from 200 to 100 that are not 
 * multiples of 3 in decending order
 *
 ******************************************************** */
namespace VBQ1{
    class Program{
        static void Main(string[] args){
            int number = 200;
            do{
                if (number % 3 != 0){
                    Console.Write("{0} ",number);
                }
                number--;
            } while (number > 100);
            Console.ReadLine();
        }
    }
}
