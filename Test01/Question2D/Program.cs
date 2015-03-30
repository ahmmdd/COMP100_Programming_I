using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * ======================      Test #1 Winter 2015      =========================
 * 
 * Name: Mohammed Juend Ahmed
 * Student ID: 300833356
 *
 * Question 2d.
 * 10 Marks.
 *
 * Write a program that prompts the user for a company name and his annual salary.
 * The  program displays the name of the company and the monthly salary. You must 
 * match the  format exactly.
 * 
 * Hint: monthly salary is annual salary divided by 12
 * [Solution: Question2D]
 */
namespace Question2D
{
    class Program
    {
        static void Main(string[] args)
        {
            String company;
            Double salary, monthlySalary;
            Console.Write("Enter the company name: ");
            company = Console.ReadLine();
            Console.Write("Enter your annual salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            monthlySalary = salary / 12;
            Console.WriteLine("The monthly salary at {0} is {1:C}", company, monthlySalary);
            Console.ReadLine();
        }
    }
}
