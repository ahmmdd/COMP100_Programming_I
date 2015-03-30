using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *******************************************************
 *
 * Question 1                             
 * do-while loop                           
 * Executable - Question1D                               
 * Name - Mohammed Juned Ahmed
 * Marks - 6                              
 * Print the numbers from 300 to 200 in decrements of 7
 *
 ******************************************************** */
namespace VDQ1{
    class Program{
        static void Main(string[] args){
            int number = 300;
            do{
                Console.Write("{0} ",number);
                number-=7;
            } while (number > 200);
            Console.ReadLine();
        }
    }
}
