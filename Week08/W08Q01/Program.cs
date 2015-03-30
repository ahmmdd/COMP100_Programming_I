using System;
/*
 * 1.	
 * Write a program to print the numbers 2 to 10 in increments of 
 * two. The output of your program should be 2 4 6 8 10 
 */
namespace W08Q01{
    class Program{
        static void Main(string[] args){
            int start = 2;
            while (start <= 10){
                Console.Write("{0} ",start);
                start += 2;
            }
            Console.ReadLine();
        }
    }
}
