using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *************************************************************************************
 * Question 4d -> 31 marks
 * Solution    -> Question4d.exe
 * 
 * Name: Mohammed Juned Ahmed
 * Date: Feburary 03, 2015
 * 
 * Purpose: Narendra's Jewelers would like a program to calculate the cost of earrings. 
 * The cost depends on the material and the amount.
 * Write a program that prompts the user for type or earrings and the amount. The program
 * multiplies the unit price by the quantity to give the cost. The unit price is given 
 * below:
 * SILVER = 1.05, GOLD = 63.7, COSTUME = .25, PLATINUM = 69.1
 * 
 * Hint:
 *     1) You must use a stitch structure
 *     2) You must use named constants
 *     3) You must check for both upper and lower case for the four materials
 ************************************************************************************* */
namespace Question4d
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double unitPrice, total;
            int units;
            Console.Write("What kind of earrings would you like. Silver/Gold/Platinum/Costume? ");
            input = Console.ReadLine();
            Console.Write("How many pairs of {0} earrings would you like? ", input);
            switch (input)
            {
                case "Silver":
                    units = Convert.ToInt32(Console.ReadLine());
                    unitPrice = 1.05;
                    total = units * unitPrice;
                    Console.WriteLine("{0} pairs of {2} earrings will cost {1:C}", units, total, input);
                    break;
                case "Gold":
                    units = Convert.ToInt32(Console.ReadLine());
                    unitPrice = 63.7;
                    total = units * unitPrice;
                    Console.WriteLine("{0} pairs of {2} earrings will cost {1:C}", units, total, input);
                    break;
                case "Platinum":
                    units = Convert.ToInt32(Console.ReadLine());
                    unitPrice = 69.1;
                    total = units * unitPrice;
                    Console.WriteLine("{0} pairs of {2} earrings will cost {1:C}", units, total, input);
                    break;
                case "Costume":
                    units = Convert.ToInt32(Console.ReadLine());
                    unitPrice = 0.25;
                    total = units * unitPrice;
                    Console.WriteLine("{0} pairs of {2} earrings will cost {1:C}", units, total, input);
                    break;
            }
            Console.ReadLine();
        }
    }
}
