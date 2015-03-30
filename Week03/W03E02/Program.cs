using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program that prompts the user for the number of siblings his has. The program should display a message, 
 * “I also have 4 siblings” (assuming that the user enters 4).
 * 
 * HINT: Use the Convert.ToInt32() method to obtain an int from an input
 */
namespace W03E02{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("How many sibllings do you have?");
            string input = Console.ReadLine();
            int numberOfSiblings = Convert.ToInt32(input);
            Console.WriteLine("I also have {0} siblings.", numberOfSiblings);
            
            Console.ReadLine();
        }
    }
}
