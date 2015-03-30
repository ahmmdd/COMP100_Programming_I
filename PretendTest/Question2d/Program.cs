using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* *************************************************************************************
 * Question 2d -> 9 marks
 * Solution    -> Question2d.exe
 * 
 * Name: Mohammed Juned Ahmed
 * Date: Feburary 03, 2015
 * 
 * Purpose: Write a program that prompts the user for his name and the number of students
 * in his class. The program will display the student's name and the number of pieces of
 * furniture that will accommodate his class. Two pieces of furniture will be needed
 * for every student.
 ************************************************************************************* */
namespace Question2d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();
            Console.Write("How many student are in your class? ");
            int students = Convert.ToInt32(Console.ReadLine());
            int furniture = students * 2;
            Console.WriteLine("Hi {0} your class will need {1} pieces of furniture", name, furniture);
            Console.ReadLine();
        }
    }
}
