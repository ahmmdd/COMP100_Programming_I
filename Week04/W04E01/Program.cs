/*
 * Name: Mohammed Juned Ahmed
 * Student# 300833356 
 * Date: Jan 27, 2015
 */
using System;
/*
 * 1.
 * Write a console-based program that prompts the user for an hourly pay rate. 
 * If the value entered is less than $7.50, display an error message
 * 
 */
namespace W04E01{
    class Program{
        static void Main(string[] args){
            Console.Write("Enter your hourly rate: ");
            double hourlyRate = Convert.ToDouble(Console.ReadLine());
            if (hourlyRate < 7.50){
                Console.WriteLine("ERROR: Rate should be more than 7.50");
            }
        }
    }
}
