using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * =========================      Test #1 Winter 2015      =========================
 * 
 * Name: Mohammed Juend Ahmed
 * Student ID: 300833356
 *
 * Question 5d.
 * 15 Marks.
 *
 * TTC has asked you to Write a program that prompts the user for the category of
 * rider. Based on the user's  input the program will display the following:
 * 
 * Input: Student
 * Message: Student pays $1.75
 * 
 * Input: Adult
 * Message: Adult pays $3.75
 * 
 * Input: Senior
 * Message: Senior pays $2.00
 * 
 * any other input
 * Message: I am sorry I don't know of that class of riders
 * 
 * You may use either the ToUpper() or ToLower() methods 
 * 
 * You must use if statement to solve this problem
 * [For full marks you need to accept all permutations of student, adult and senior]
 * 
 * [Solution: Question5D]
 */
namespace Question5D{
    class Program{
        static void Main(string[] args){
            double cost;
            Console.Write("What is type of ridership? ");
            string rider = Console.ReadLine().ToUpper();
            if (rider == "STUDENT"){
                cost = 1.75;
                Console.WriteLine("{0} pays {1:C}", rider, cost);
            }else if (rider == "ADULT"){
                cost = 3.75;
                Console.WriteLine("{0} pays {1:C}", rider, cost);
            }else if (rider == "SENIOR"){
                cost = 2.00;
                Console.WriteLine("{0} pays {1:C}", rider, cost);
            }else{
                Console.WriteLine("I am sorry I don't know of that class of riders");
            }
            Console.ReadLine();
        }
    }
}
