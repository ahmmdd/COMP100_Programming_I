/*
 * Name: Mohammed Juned Ahmed
 * Student# 300833356 
 * Date: Jan 27, 2015
 */
using System;
/*
 * 4.	
 * Write a console-based program that prompts a user for an hourly pay rate. If 
 * the user enters values less than $7.50 or greater than $49.99, prompt the 
 * user again. If the user enters an invalid value again, display an appropriate 
 * error message. If the user enters a valid value on either the first or second 
 * attempt, display the pay rate as well as the weekly rate, which is calculated 
 * as 40 times the hourly rate. 
 * 
 */
namespace W04E04{
    class Program{
        static void Main(string[] args){
            double hourlyRate, weeklyRate;
            Console.Write("Enter your hourly rate: ");
            hourlyRate = Convert.ToDouble(Console.ReadLine());
            if (hourlyRate < 7.50 || hourlyRate > 49.99){
                Console.Write("Enter your hourly rate: ");
                hourlyRate = Convert.ToDouble(Console.ReadLine());
                if (hourlyRate < 7.50 || hourlyRate > 49.99){
                    Console.WriteLine("ERROR: Rate should be more than 7.50 and less than 49.99.");
                }else{
                    Console.WriteLine("You have entered a Valid Rate of {0:C}", hourlyRate);
                    Console.WriteLine("Your pay rate is {0:C} per hour.", hourlyRate);
                    weeklyRate = hourlyRate * 40;
                    Console.WriteLine("Your weekly pay rate is {0:C} per week.", weeklyRate);
                }
            }else{
                Console.WriteLine("You have entered a Valid Rate of {0:C}", hourlyRate);
                Console.WriteLine("Your pay rate is {0:C} per hour.", hourlyRate);
                weeklyRate = hourlyRate * 40;
                Console.WriteLine("Your weekly pay rate is {0:C} per week.", weeklyRate);
            }

            Console.ReadLine();
        }
    }
}
