using System;
/*
 * 2.	
 * Write a Program to compute the sum of eight numbers that will 
 * be provided by the user.
 */
namespace W08Q02{
    class Program{
        static void Main(string[] args){
            int sum = 0;
            int a = 0;
            int input;
            while (a < 8){
                Console.Write("Enter an interger: ");
                input = Convert.ToInt32(Console.ReadLine());
                sum += input;
                a++;
            }
            Console.WriteLine("Sum of 8 numbers is {0}", sum);
            Console.ReadLine();
        }
    }
}
