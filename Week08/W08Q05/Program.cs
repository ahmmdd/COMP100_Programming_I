using System;
/*
 * 5.	
 * Write a C# program that converts feet to meters. The program 
 * should display feet from 3 to 30 in three-foot increments and 
 * the corresponding meter equivalents. Use the relationship that
 * 1 meter is equivalent to 3.28 feet. 
 */
namespace W08Q05{
    class Program{
        static void Main(string[] args){
            double feet, meters;
            feet = 3;
            while (feet <= 30){
                meters = feet * 3.28;
                Console.WriteLine("Meters: {0:f} | Feet: {1:f}", feet, meters);
                feet += 3;
            }
            Console.ReadLine();
        }
    }
}
