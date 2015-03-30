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
 * Question 3d.
 * 5 Marks.
 *To char (by implicit cast)
(char)65;

 * Write a program that prompts the user for a number. The program prints the 
 * number and the letter equivalent. The letter equivalent is obtained by casting
 * the letter to an int. You must match the format exactly.
 * 
 * [For testing purposes use number in the range 48 to 90]
 * [Solution: Question3D]
 */
namespace Question3D
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            char letter;
            Console.Write("Enter an interger: ");
            number = Convert.ToInt32(Console.ReadLine());
            letter = (char)Convert.ToChar(number);
            Console.WriteLine("The letter {0} is equivalent to the number {1}", letter, number);
            Console.ReadLine();

        }
    }
}
