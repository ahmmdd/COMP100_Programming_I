/*
 * Name: Mohammed Juned Ahmed
 * Student# 300833356 
 * Date: Jan 27, 2015
 */
using System;
/*
 * 2.
 * Write a console-based program that prompts a user for an 
 * hourly pay rate. If the value entered is less than $7.50 or 
 * greater than $49.99, display an error message; otherwise, 
 * display a message indicating that the rate is okay.
 * 
 */
namespace W04E02{
    class Program{
        static void Main(string[] args){
            Console.Write("Enter your hourly rate: ");
            double hourlyRate = Convert.ToDouble(Console.ReadLine());
            if (hourlyRate < 7.50 || hourlyRate > 49.99)
            {
                Console.WriteLine("ERROR: Rate should be more than 7.50 and less than 49.99.");
            }
            else
            {
                Console.WriteLine("You have entered a Valid Rate of {0}", hourlyRate);
            }
            Console.ReadLine();
        }
    }
}
