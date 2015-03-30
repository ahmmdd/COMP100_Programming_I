using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *******************************************************
 * 
 * Question 0                             
 * for loop                           
 * Executable - Question0C                               
 * Name - Mohammed Juned Ahmed
 * Marks -  6                             
 * Prompts the user for his/her name. The program will 
 * print a greeting 10 times
 *
 ******************************************************** */
namespace VCQ0{
    class Program{
        static void Main(string[] args){
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();
            for (int i = 0; i < 10; i++){
                Console.WriteLine("Hi {0} how are you?", input);
            }
            Console.ReadLine();
        }
    }
}
