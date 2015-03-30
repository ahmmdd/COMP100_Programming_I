using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program to calculate and display the potential difference between the ends of a wire. 
 * The program will prompt the user for the current flowing and the resistance of the wire. 
 * 
 * (Potential difference is the product of the current and the resistance of the wire and may 
 * include a fractional part)
 */
namespace W03E08{
    class Program{
        static void Main(string[] args){
            double current, resistance;
            Console.Write("Enter Current flowing: ");
            current = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter Resistance of the wire: ");
            resistance = Convert.ToDouble(Console.ReadLine());

            double potentialDiff = current * resistance;
            Console.WriteLine("\nThe potiential difference is {0}.", potentialDiff);
            Console.ReadLine();
        }
    }
}
