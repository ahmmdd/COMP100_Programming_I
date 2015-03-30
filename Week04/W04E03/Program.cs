/*
 * Name: Mohammed Juned Ahmed
 * Student# 300833356 
 * Date: Jan 27, 2015
 */
using System;
/*
 * 3.	
 * If money is left in a particular bank for more than 5 years, the interest rate given by 
 * the bank is 7.5%, else the interest rate is 5.4%. Write a program that prompt the user for 
 * the number of years that the money was left in the bank and display the appropriate interest 
 * rate depending on the value input. How many runs should you make to very that it works correctly?
 * 
 */
namespace W04E03{
    class Program{
        static void Main(string[] args){
            int years;
            double interestA, interestB;
            interestA = 7.5;
            interestB = 5.4;
            Console.Write("Enter number of years that the money was left in the bank?\n\t\t");
            years = Convert.ToInt32(Console.ReadLine());
            if (years > 5)
            {
                Console.WriteLine("Interest Rate will be {0} percent.", interestA);
            }
            else
            {
                Console.WriteLine("Interest Rate will be {0} percent.", interestB);
            }
            Console.ReadLine();
        }
    }
}
