using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * =========================      Test #1 Winter 2015      =========================
 * 
 * Name: Mohammed Juend Ahmed
 * Student ID: 300833356
 *
 * Question 4d.
 * 15 Marks.
 *
 * Canada Computer Store has asked you to write a program that prompts the user 
 * for the device that she would like to pruchase. Based on the user's input 
 * the program will display the following:
 * 
 * Input: Tablet
 * Message: A tablet cost $475.00
 * 
 * Input: Laptop
 * Message: A laptop cost $650.00
 * 
 * Input: Desktop
 * Message: A desktop cost $899.00
 * 
 * any other input
 * Message: I am sorry I don't carry those devices
 * 
 * You may use either the ToUpper() or ToLower() methods 
 * 
 * [For full marks you need to accept all permutations of tablet, laptop and desktop]
 * 
 * [Solution: Question4D]
 */
namespace Question4D
{
    class Program
    {
        static void Main(string[] args)
        {
            String input; double cost;
            Console.Write("What is kind ot device would you like to buy? ");
            input = Console.ReadLine().ToLower();
            if (input == "tablet")
            {
                cost = 475;
                Console.WriteLine("A {0} cost {1:C}", input, cost);
            }
            else if (input == "laptop")
            {
                cost = 650;
                Console.WriteLine("A {0} cost {1:C}", input, cost);
            }
            else if (input == "desktop")
            {
                cost = 899;
                Console.WriteLine("A {0} cost {1:C}", input, cost);
            }
            else
            {
                Console.WriteLine("I am sorry I don't carry those devices");
            }
            Console.ReadLine();
        }
    }
}
