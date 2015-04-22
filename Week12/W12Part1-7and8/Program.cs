using System;

namespace W12Part1_7_8{
    class Program{
        #region MAIN
        static void Main(string[] args){
            //DisplayMenu();
            ShowMenu();
        }
        #endregion
        #region Question 7
        static void DisplayMenu(){
            Console.WriteLine(" ==============Narendra's Computer Systems==============");
            Console.WriteLine("|\t1. To calculate area of a Circle\t\t|");
            Console.WriteLine("|\t2. To calculate area of a Triangle\t\t|");
            Console.WriteLine("|\t3. To calculate area of a Cube\t\t\t|");
            Console.WriteLine("|\t0. To end program\t\t\t\t|");
            Console.WriteLine(" =======================================================");
            Console.Write("\tEnter the number of your choice --> ");

        }
        #endregion
        #region Question 8
        static void ShowMenu(){
            int input;
            for (; ; ){
                Console.Clear();
                DisplayMenu();
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1){
                    CalculateAreaOfCircle();
                    continue;
                }else if (input == 2){
                    CalculateAreaOfTriangle();
                    continue;
                }else if (input == 3){
                    CalculateAreaOfCube();
                    continue;
                }else if (input == 0){ break; }
                else { continue;  }
            }
        }
        static void CalculateAreaOfCircle(){
            Double radius, area;
            Console.Write("Enter radius of Circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radius;
            Console.WriteLine("Area of the circle is {0:f} for radius {1}", area, radius);

            Console.Write("Enter any key to continue...");
            Console.ReadLine();
        }
        static void CalculateAreaOfTriangle(){
            Double area, height, basee;
            Console.Write("Enter base of triangle: ");
            basee = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height of triangle: ");
            height = Convert.ToDouble(Console.ReadLine());
            area = basee * height / 2;
            Console.WriteLine("The area of triangle is {0}", area);

            Console.Write("Enter any key to continue...");
            Console.ReadLine();
        }
        static void CalculateAreaOfCube(){
            Double side, area;
            Console.Write("Enter length: ");
            side = Convert.ToDouble(Console.ReadLine());
            area = side * side;
            Console.WriteLine("Area of the cube is {0:F}", area);
            Console.Write("Enter any key to continue...");
            Console.ReadLine();
        }

        #endregion
    }
}
