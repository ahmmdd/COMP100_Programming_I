using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *************************************************************************************
 * Question 3d -> 20 marks
 * Solution    -> Question3d.exe
 * 
 * Name: Mohammed Juned Ahmed
 * Date: February 03, 2015
 * 
 * Purpose: Write a program that will calculate the cost of a sale. Cost is the sales
 * minus any discount plus taxes. The program will  prompt the user for the sales amount 
 * and then calulate and display the current month wage.
 * 
 * Calculation
 * for sales over 100
 *    adjustment = (sales over $100) * 0.25 * 0.14;
 * for sales 100 and less   
 *    adjustment = sales * 0.14;
 *    
 * cost = sales + adjustment
 * 
 * Hint:
 *     1) Use placeholders with the "c" modifier to display currency correctly
 *     2) You must use named constants (three in this question - 100, .25, .14)
 ************************************************************************************* */

namespace Question3d
{
    class Program
    {
        static void Main(string[] args)
        {
            double sales, adjustment, cost;
            double a = 100;
            double b = 0.25;
            double c = 0.14;
            Console.Write("Enter total sales before tax: ");
            sales = Convert.ToDouble(Console.ReadLine());
            if (sales <= a)
            {
                adjustment = sales * c;
            }
            else
            {
                adjustment = sales * b * c;
            }
            cost = sales + adjustment;
            Console.WriteLine("If your sale is {0:C} you will pay {1:C}", sales, cost);

            Console.ReadLine();
        }
    }
}
