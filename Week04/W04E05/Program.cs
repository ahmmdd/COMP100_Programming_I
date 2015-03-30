/*
 * Name: Mohammed Juned Ahmed
 * Student# 300833356 
 * Date: Jan 27, 2015
 */
using System;
/*
 * 5.	
 * Write a console-based program that accepts a user’s message and 
 * determines whether it is short enough for a social networking 
 * service that does not accept messages of more than 140 characters. 
 * [Hint: if the user’s input is assigned to the variable message 
 * then message.Length with give the number of characters in the input]
 * 
 */
namespace W04E05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Message:\n");
            string message = Console.ReadLine();
            Console.Clear();
            if (message.Length < 140)
            {
                Console.WriteLine("\n\nVALID MESSAGE!!!\n\nMESSAGE LENGTH: {1}\n\n{0}", message, message.Length);
            }
            else
            {
                Console.WriteLine("\n\nINVALID MESSAGE!!!\n\nMESSAGE LENGTH: {1}\n\n{0}", message, message.Length);
            }

            Console.ReadLine();
        }
    }
}
