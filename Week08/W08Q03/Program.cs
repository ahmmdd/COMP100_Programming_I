using System;
/*
 * 3.	
 * Write a Program to compute the average of ten numbers which 
 * will be entered by the user.
 */
namespace W08Q03{
    class Program{
        static void Main(string[] args){
            int sum = 0;
            int a = 0;
            int input;
            while (a < 10){
                Console.Write("Enter an interger: ");
                input = Convert.ToInt32(Console.ReadLine());
                sum += input;
                a++;
            }
            double avg = sum / 10;
            Console.WriteLine("The average is {0}", avg);
            Console.ReadLine();
        }
    }
}
