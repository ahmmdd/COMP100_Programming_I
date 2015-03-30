using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Adult ticket cost $3.75 and child ticket cost $2.25. Write a program to prompt the 
 * user for the amount of adult and child ticket that she needs. The program will 
 * display a user friendly message of the number of tickets brought as well as the total 
 * cost. (Use the "C" format-specifier for currency)
 * */
namespace W03Q09
{
    class Program
    {
        static void Main(string[] args)
        {
            double adult, adultPrice, child, childPrice, totalTickets, totalAdultPrice, totalChildPrice, totalPrice;
            adultPrice = 3.75;
            childPrice = 2.25;
            Console.WriteLine("How many adult tickets do you want?");
            adult = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many child tickets do you want?");
            child = Convert.ToDouble(Console.ReadLine());
            totalAdultPrice = adult * adultPrice;
            totalChildPrice = child * childPrice;
            totalTickets = adult + child;
            totalPrice = totalAdultPrice + totalChildPrice;
            //{1:C} REPRESENTS THE VALU IN CURRENCY
            Console.WriteLine("You bought {0} tickets, and your total is {1:C}.", totalTickets, totalPrice);
            Console.ReadLine();

        }
    }
}
