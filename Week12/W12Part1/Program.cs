using System;

namespace W12Part1{
    class Program{
        #region MAIN
        static void Main(string[] args){
            
            //Question 1
            DisplayPersonalInfo();
            Console.Write("Enter any key to continue...");
            Console.ReadLine();
            Console.Clear();
            
            //Question 2
            CalculateTuition();
            Console.Write("Enter any key to continue...");
            Console.ReadLine();
            Console.Clear();
            
            //Question 3
            CalculateAreaOfCircle();
            Console.Write("Enter any key to continue...");
            Console.ReadLine();
            Console.Clear();

            //Question 4
            CalculateAreaOfTriangle();
            Console.Write("Enter any key to continue...");
            Console.ReadLine();
            Console.Clear();
            
            //Question 5
            CalculateSaleCommission();
            Console.Write("Enter any key to continue...");
            Console.ReadLine();
            Console.Clear();
            
            //Question 6
            DisplaySineTable();
            Console.Write("Enter any key to continue...");
            Console.ReadLine();
            Console.Clear();

            Console.ReadLine();
        }
        #endregion
        #region Question 1
        static void DisplayPersonalInfo(){
            string name, school, program, course;
            Console.Write("Enter your name? ");
            name = Console.ReadLine();
            Console.Write("Which school do you go to? ");
            school = Console.ReadLine();
            Console.Write("What program are you in? ");
            program = Console.ReadLine();
            Console.Write("What is your favorite course? ");
            course = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Name: {0}\nSchool: {1}\nProgram: {2}\nFavorite Course: {3}", name, school, program, course);
        }
        #endregion
        #region Question 2
        static void CalculateTuition(){
            double cost; 
            int numberOfCourses;
            Console.Write("How many courses are you taking? ");
            numberOfCourses = Convert.ToInt32(Console.ReadLine());
            cost = (double) numberOfCourses * 569.99;
            Console.WriteLine("Tution Cost for {0} courses is {1:C}", numberOfCourses, cost);
        }
        #endregion
        #region Question 3
        static void CalculateAreaOfCircle(){
            Double radius, area;
            Console.Write("Enter radius of Circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radius;
            Console.WriteLine("Area of the circle is {0:f} for radius {1}", area, radius);

        }
        #endregion
        #region Question 4
        static void CalculateAreaOfTriangle(){
            Double area, height, basee;
            Console.Write("Enter base of triangle: ");
            basee = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height of triangle: ");
            height = Convert.ToDouble(Console.ReadLine());
            area = basee * height / 2;
            Console.WriteLine("The area of triangle is {0}", area);

        }
        #endregion
        #region Question 5
        static void CalculateSaleCommission(){
            double sales,commission;
            Console.Write("Enter your sales amount:");
            sales = Convert.ToDouble(Console.ReadLine());
            if (sales > 1000){
                commission = 0.0025 * sales;
                Console.WriteLine("Your commission is {0:f}", commission);
            }else if (sales > 0 || sales <= 1000){
                Console.WriteLine("No commission because your sales are below $1000.00");
            }else{
                Console.WriteLine("Invalid Input!!!");
            }
        }
        #endregion
        #region Question 6
        static void DisplaySineTable(){
            double sine, startingValue, stepSize;
            Console.Write("Enter Starting Value: ");
            startingValue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Step Size: ");
            stepSize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Radians\t| Sine");
            Console.WriteLine("--------|--------");
            for (int i = 0; i < 10; i++){
                sine = Math.Sin(startingValue);
                Console.WriteLine("{0}\t| {1:F4}", startingValue, sine);
                startingValue += stepSize;
            }
        }
        #endregion
    }
}
