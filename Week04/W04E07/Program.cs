/*
 * Name: Mohammed Juned Ahmed
 * Student# 300833356 
 * Date: Jan 27, 2015
 */
using System;
/*
 * 7.	
 * Write a console-based program that prompts the user for an hourly pay rate 
 * and hours worked. Compute gross pay (hours times pay rate), withholding tax,
 * and net pay (gross pay minus withholding tax). Withholding tax is computed 
 * as a percentage of gross pay based on the following:
 * 
 *              Gross Pay	         |       Withholding     |    Percentage
 *        ---------------------------|-----------------------|-----------------
 *          Up to and including      |         300.00	     |      10%
 *              More than            |         300.00        |     	12%
 *              
 */

namespace W04E07{
    class Program{
        static void Main(string[] args){
            double hourlyRate, hoursWorked, grossPay, withHolding, netPay;
            Console.Write("Enter your hourly rate: ");
            hourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter your hours worked: ");
            hoursWorked = Convert.ToDouble(Console.ReadLine());
            grossPay = hourlyRate * hoursWorked;
            Console.WriteLine("Gross pay is: {0:C}", grossPay);
            if (grossPay <= 300)
            {
                withHolding = grossPay * .10;
                netPay = grossPay - withHolding;
                Console.WriteLine("With Holding tax is: {0:C}",withHolding);
                Console.WriteLine("Net pay is: {0:C}",netPay);
                
            }
            else if (grossPay > 300)
            {
                withHolding = grossPay * .12;
                netPay = grossPay - withHolding;
                Console.WriteLine("With Holding tax is: {0:C}", withHolding);
                Console.WriteLine("Net pay is: {0:C}", netPay);
                
            }

            Console.ReadLine();
        }
    }
}
