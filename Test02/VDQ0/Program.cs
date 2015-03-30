using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *******************************************************
 * 
 * Question 0                             
 * for loop                           
 * Executable - Question0D                 
 * Name - Mohammed Juned Ahmed
 * Marks - 6                              
 * Prompts the user for a number. The program will 
 * print a greeting that many times
 *
 ******************************************************** */
namespace VDQ0{
    class Program{
        static void Main(string[] args){
            Console.Write("Enter a small number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < input; i++){
                Console.WriteLine("Hi Narendra how are you?", input);
            }
            Console.ReadLine();
        }
    }
}
