using System;
/*
 * 6.	
 * Write a program that displays a conversion table from 
 * Fahrenheit to Celsius. The program must request the starting 
 * Fahrenheit value, the ending Fahrenheit value, and the 
 * increment. Thus, instead of the condition checking for a fixed
 * count, the condition checks for the ending Fahrenheit value
 */
namespace W08Q06{
    class Program{
        static void Main(string[] args){
            double fahrenheitStart, fahrenheitEnd, celsius;
            double fahrenheitIncr, fahrenheit;
            Console.Write("Enter Fahrenheit Start Value: ");
            fahrenheitStart = Convert.ToDouble(Console.ReadLine());
            double a = ( 5.0 / 9.0);
            Console.Write("Enter Fahrenheit End Value: ");
            fahrenheitEnd = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Increment Value: ");
            fahrenheitIncr = Convert.ToInt32(Console.ReadLine());
            fahrenheit = fahrenheitStart;
            for (double i = fahrenheitStart; i <= fahrenheitEnd; i += fahrenheitIncr){
                if (i == fahrenheitStart){
                    celsius = (a * (fahrenheit - 32));
                    fahrenheit += fahrenheitIncr;
                    Console.WriteLine("Fahrenheit {0} is {1:f} Celsius.", fahrenheit, celsius);
                }else{
                    celsius = (a * (fahrenheit - 32));
                    fahrenheit += fahrenheitIncr;
                    Console.WriteLine("Fahrenheit {0} is {1:f} Celsius.", fahrenheit, celsius);
                }
            }
            Console.ReadLine();
        }
    }
}
