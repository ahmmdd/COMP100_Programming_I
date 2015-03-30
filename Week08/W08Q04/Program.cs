using System;
/*
 * 4.	
 * Write a C# program that displays a conversion table from 
 * gallons to liters. The program should display gallons from 
 * 10 to 20 in one-gallon increments and the corresponding litre 
 * equivalents. Use the relationship that 1 gallon contains 3.785 
 * liters.
 */
namespace W08Q04{
    class Program{
        static void Main(string[] args){
            double gallon, liters;
            gallon = 10;
            while(gallon <= 20){
                liters = gallon * 3.785;
                Console.WriteLine("Gallons: {1:f} | Literss: {0:f}", liters, gallon);

                gallon++;
            }
            Console.ReadLine();
        }
    }
}
