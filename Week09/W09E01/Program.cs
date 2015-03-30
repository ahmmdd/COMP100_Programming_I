using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 1.	
 * Write a method that does not return a value and does not take 
 * any argument. This method display the following menu choice on
 * the screen
 * 
 * Calculation Menu
 * 1) Area of Rectangle
 * 2) Area of Circle
 * 3) Volume of Cube
 * 4) Volume of Sphere
 * 0) To Exit
 * 
 * You may beautify the output to your own likings. You don’t 
 * have to implement the functionalities of the various menu 
 * choices Call this method from your main.
 * 
 */
namespace W09E01
{
    class Program
    {
        static void Main(string[] args)
        {
                    //RECTANGLE
                    Console.Write("Enter Length of Rectangle: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Width of Rectangle: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    double area = RectangleArea(length, width);
                    Console.WriteLine("Area of Rectangle is {0:f}", area);
                    Console.ReadLine(); Console.Clear();
              
                    //CIRCLE
                    Console.Write("Enter Radius of Circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double area1 = CircleArea(radius);
                    Console.WriteLine("Area of Circle is {0:f}", area1);
                    Console.ReadLine(); Console.Clear();
                
                    //CUBE
                    Console.Write("Enter Length of Cube: ");
                    double length1 = Convert.ToDouble(Console.ReadLine());
                    double volume = CubeVolume(length1);
                    Console.WriteLine("Volume of Cube is {0:f}", volume);
                    Console.ReadLine(); Console.Clear();
               
                    //SPHERE
                    Console.Write("Enter radius of Sphere: ");
                    double radius1 = Convert.ToDouble(Console.ReadLine());
                    double volume1 = SphereVolume(radius1);
                    Console.WriteLine("Volume of Sphere is {0:f}.", volume1);
          
            Console.ReadLine();
        }//end main
        static double RectangleArea(double a, double b)
        {
            double area;
            area = a * b;
            return area;
            //Console.WriteLine("Area of Rectangle is {0}", area);
        }
        static double CircleArea(double radius)
        {
            double area;
            area = 2 * Math.PI * radius;
            return area;
        }
        static double CubeVolume(double length)
        {
            double volume = length * length * length;
            return volume;
        }
        static double SphereVolume(double radius)
        {
            double volume = 4 / 3 * Math.PI * radius * radius * radius;
            return volume;
        }
        static void Menu()
        {
            Console.WriteLine("Calculation Menu\n1) Area of Rectangle\n2) Area of Circle\n3) Volume of Cube\n4) Volume od Sphere\n0) To Exit\nPlease select one of the options above: ");
        }
    }//end class
}