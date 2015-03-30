using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *******************************************************
 * 
 * Question 1                             
 * do-while loop                           
 * Executable - Question1A             
 * Name - Mohammed Juned Ahmed
 * Marks - 6                              
 * Print the multiples of 11 from 600 to 500 in descending
 * order
 *
 ******************************************************** */
namespace VAQ1{
    class Program{
        static void Main(string[] args){
            int number = 600;
            do{
                if (number % 11 == 0){
                    Console.Write("{0} ",number);
                }
                number--;
            } while (number > 500);
            Console.ReadLine();
        }
    }
}
