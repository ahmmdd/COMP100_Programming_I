using System;

namespace W12P03{
    class Program{
        static void Main(string[] args){
            /*
            //Question1
            Console.WriteLine(CaculateDifference(50, 25));
            Console.WriteLine(CaculateDifference(30, 60));
            Console.WriteLine(CaculateDifference(20, 20));
            
            //Question2
            Console.WriteLine(CalculatePower(2, 1));
            Console.WriteLine(CalculatePower(1, 2));
            
            //Question3
            Console.WriteLine(CalculateTuitionFee(5, 200));
            Console.WriteLine(CalculateTuitionFee(6, 160));
            Console.WriteLine(CalculateTuitionFee(4, 250));
            Console.WriteLine(CalculateTuitionFee(7, 165));
            
            //Question4
            Console.WriteLine(CalculateCommission(900));
            Console.WriteLine(CalculateCommission(1000));
            Console.WriteLine(CalculateCommission(2000));
            
            //Question5
            Console.WriteLine("{0:C}",Question5());
            
            //Question6
            Console.WriteLine(CalculateGravitationalAttraction(100,500,78000));
            
            //Question7
            Console.WriteLine(CalculateHeronFormula(6, 6, 6));
            
            //Question8
            Console.WriteLine(ConvertCelciusToFahrenheit(0));
            Console.WriteLine(ConvertCelciusToFahrenheit(50));
            Console.WriteLine(ConvertCelciusToFahrenheit(100));
            
            //Question9
            Console.WriteLine(ConvertFahrenheitToCelsius(0));
            Console.WriteLine(ConvertFahrenheitToCelsius(32));
            Console.WriteLine(ConvertFahrenheitToCelsius(212));
            
            //Question10
            Console.WriteLine(ConvertCelsiusToKelvin(-196));
            Console.WriteLine(ConvertCelsiusToKelvin(0));
            Console.WriteLine(ConvertCelsiusToKelvin(100));
            
            //Question11
            Console.WriteLine(ConvertFahrenheitToKelvin(0));
            Console.WriteLine(ConvertFahrenheitToKelvin(100));
            Console.WriteLine(ConvertFahrenheitToKelvin(212));
            
            //Question12
            Console.Write("Enter integer: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Square(a);
            Console.WriteLine(Cube(b));
            
            //Question13
            double sale = DailySales();
            Console.WriteLine(CalculateCommissionOfDailySales(sale));
            */
        }
        #region Questions
        #region Question 1
        /*
		1.	
		Write a method called CaculateDifference(int firstNumber, int 
		secondNumber). This method will calculate and return the 
		difference between the two number i.e. it will subtract the 
		smaller one from the larger one and then return that value. Call 
		the CaculateDifference() method four times from your program Main() 
		method supplying different arguments each time.		

		To use the result of a method call you should assign it to a 
		variable, or simply display the return value with a Console.Write() 
		statement
		*/
        static int CaculateDifference(int firstNumber, int secondNumber){
            int difference;
            if (firstNumber > secondNumber){
                difference = firstNumber - secondNumber;
            }else if (firstNumber < secondNumber){
                difference = secondNumber - firstNumber;
            }else{
                difference = 0;
            }
            return difference;
        }
        #endregion
        #region Question 2
        /*
		2.	
		Write a method called CalculatePower(double current, double 
		resistance). The method will calculate and return the electrical 
		power dissipated in a circuit. [P=I^2R]
		*/
        static double CalculatePower(double current, double resistance){
            double power;
            power = current * current * resistance;
            return power;
        }
        #endregion
        #region Question 3
        /*
		3.	
		Write a method called CaculateTuitionFee(int numberOfCourses, 
		double costPerCourse). This method will calculate and return the 
		required fees amount. [Fees = number of courses * cost per course
		 + 15.25]. Call the CaculateTuitionFee() method four times from 
		 your program Main() method supplying different arguments each 
		 time.
		*/
        static double CalculateTuitionFee(int numberOfCourses, double costPerCourse){
            double fees;
            fees = (numberOfCourses * costPerCourse) + 15.25;
            return fees;
        }
        #endregion
        #region Question 4
        /*
		4.	
		Write a method called CalculateCommission(double saleAmount). 
		This method will calculate and return a sales representation’s 
		commission.[over 1000 1% commission]. Call the CalculateCommission()
		method three times from your program Main() method, supplying 
		900, 1000 and 2000.
		*/
        static double CalculateCommission(double saleAmount){
            double commission;
            if (saleAmount > 1000){
                commission = saleAmount * 0.01;
                return commission;
            }else{ return 0; }
        }
        #endregion
        #region Question 5
        /*
		5.
		Write a method that does not take any argument. The method will 
		prompt the user for the number of burgers that he wants to buy. 
		The method will calculate and return the amount of money that 
		will be required. [One burger cost $1.39]
		*/
        static double Question5(){
            double totAmount, burgerAmount;
            Console.Write("How many Burgers do you want? ");
            int numberOfBurgers = Convert.ToInt32(Console.ReadLine());
            burgerAmount = 1.39;
            totAmount = numberOfBurgers * burgerAmount;
            return totAmount;

        }
        #endregion
        #region Question 6
        /*
		6.
		“Newton's law of universal gravitation states that every point 
		mass in the universe attracts every other point mass with a force 
		that is directly proportional to the product of their masses and 
		inversely proportional to the square of the distance between them.” 
		Write a method called CalculateGravitationalAttraction() that 
		takes three double arguments (masses of the two bodies and the 
		distance between them). The method will calculate and return the 
		force of attraction [F=G (m1 m2)/d^2], where G = 6.673x10-11]. 
        In your main call this method with the masses of the earth, moon 
        and the distance between them and display the resulting force.
		*/
        static double CalculateGravitationalAttraction(double m1, double m2, double distance){
            double forceOfAttraction, g;
            g = 6.673 * Math.Exp(-11);
            forceOfAttraction = g * m1 * m2/(distance*distance);
            return forceOfAttraction;
        }
        #endregion
        #region Question 7
        /*
		7.
		Heron’s formula allows you to calculate the area of any triangle 
		given the length of the three sides.[A=√(s(s-a)(s-b)(s-c)] where [s=(a+b+c)/2].
		*/
        static double CalculateHeronFormula(double a, double b, double c){
            double area, s;
            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
        #endregion
        #region Question 8
        /*
		8.
		Write a method called ConvertCelciusToFahrenheit that takes a 
		double argument. The method will calculate and return the 
		Fahrenheit equivalent of the argument. [F = C * 9 / 5 + 32]. In 
		your main call this method with arguments 0, 50 and 100 and 
		display the results.
		*/
        static double ConvertCelciusToFahrenheit(double celcius){
            double fahrenheit;
            fahrenheit = celcius * (9.0 / 5) + 32;
            return fahrenheit;
        }
        #endregion
        #region Question 9
        /*
		9.
		Write a method called ConvertFahrenheitToCelsius that takes a 
		double argument. The method will calculate and return the Celsius 
		equivalent of the argument. [C = (F – 32) * 5 / 9]. In your main 
		call this method with arguments 0, 32 and 212 and display the 
		results.
		*/
        static double ConvertFahrenheitToCelsius(double fahrenheit){
            double celcius;
            celcius = (fahrenheit - 32) * (5.0 / 9);
            return celcius;
        }
        #endregion
        #region Question 10
        /*
		10.
		Write a method called ConvertCelsiusToKelvin that takes a double 
		argument. The method will calculate and return the Kelvin 
		equivalent of the argument. [K = C + 273.15]. In your main call 
		this method with arguments -196, 0 and 100 and display the results.
		*/
        static double ConvertCelsiusToKelvin(double celcius){
            double kelvin;
            kelvin = celcius + 273.15;
            return kelvin;
        }
        #endregion
        #region Question 11
        /*
		11.	
		Write a method call ConvertFahrenheitToKelvin that takes a double 
		argument. The method will calculate and return the Kelvin 
		equivalent of the argument. [Use the two previous methods to 
		assist in your computation]. In your main call this method three 
		times and display the results.
		*/
        static double ConvertFahrenheitToKelvin(double fahrenheit){
            double kelvin;
            kelvin = (fahrenheit - 32) * (5.0 / 9) + 273.15;
            return kelvin;
        }
        #endregion
        #region Question 12
        /*
		12.	
		Write two methods: Square(int) and Cube(int), these methods 
		return the square and the cube of its argument. In your main 
		method prompt the user for an integer, then pass this integer to 
		the Square method and then pass the results to the Cube method. 
		In the main method print out the final results.
		*/
        static int Square(int a){
            int square; 
            square = a * a;
            return square;
        }
        static int Cube(int a){
            int cube = a * a * a;
            return cube;
        }
        #endregion
        #region Question 13
        /*
		13.	
		Write two methods that will be called from main. The first 
		method should prompt the user for his daily sales amount. The 
		method should accept and return this amount. The second method 
		should calculate and return his commission based on the 
		following: 0-999 3%, 1000-2999 4% and over 3000 5%. In your main 
		call the two methods and display the results in a readable manner
		*/
        static double DailySales(){
            Console.Write("What is the daily sales? ");
            double sales = Convert.ToDouble(Console.ReadLine());
            return sales;
        }
        static double CalculateCommissionOfDailySales(double sales){
            double commission;
            if (sales >= 0 && sales < 1000){
                commission = sales * 0.03;
            }else if (sales >= 1000 && sales < 3000){
                commission = sales * 0.04;
            }else if (sales >= 3000){
                commission = sales * 0.05;
            }else{
                commission = 0;
            }
            return commission;
        }
        #endregion
        #endregion
    }
}
