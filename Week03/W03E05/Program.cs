using System;
/*
 * Write a program to prompt the user to enter a single character. The program should display a message 
 * like “Your response was y”. For this question, you must use a variable of type char.
 * 
 * Use the Convert.ToChar() method to obtain a char from an input
 */
namespace W03E05{
    class Program{
        static void Main(string[] args){
            Console.Write("Enter Single Character: ");
            char character = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Your response was {0}", character);
            Console.ReadLine();
        }
    }
}
