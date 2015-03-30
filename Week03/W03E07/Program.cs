using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program to calculate the area of a circle. The user will enter the radius of the circle and the 
 * program will calculate and display the area according to the formula (area = 3.14 * radius * radius). 
 * You must accept fractions as the input.
 * 
 * Use the Convert.ToDouble() method to obtain a double from an input
 */
namespace W03E07{
    class Program{
        static void Main(string[] args){

            Console.Write("Enter Radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = 3.14 * radius * radius;
            Console.WriteLine("The area of Circle is {0:f} square meter.", area);
            Console.ReadLine();

        }
    }
}
