using System;
/*
 * 10.	
 * A conversion table of Celsius to Fahrenheit temperature. The 
 * table must start with 0 Celsius and end at 100 Celsius with 
 * increments of 10. (Fahrenheit = Celsius * 9/5 + 32)
 */
namespace W07Q10{
    class Program{
        static void Main(string[] args){
            double celsius, fahrenheit, nine, five;
            nine = 9.0;
            five = 5.0;
            celsius = 0;
            do{
                fahrenheit = ((celsius * (nine / five)) + 32);
                Console.WriteLine("Celsius: {0}\tFahrenheit: {1}", celsius, fahrenheit);
                celsius += 10;
            }while (celsius <= 100);
            Console.ReadLine();
        }
    }
}
