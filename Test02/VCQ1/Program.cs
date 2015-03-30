using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *******************************************************
 *
 * Question 1                             
 * do-while loop                           
 * Executable - Question1C             
 * Name - Mohammed Juned Ahmed
 * Marks - 6                              
 * Print the numbers from 200 to 300 in increments of 7 
 *
 ******************************************************** */
namespace VCQ1{
    class Program{
        static void Main(string[] args){
            int number = 200;
            do{
                Console.Write("{0} ",number);
                number+=7;
            } while (number < 300);
            Console.ReadLine();
        }
    }
}
