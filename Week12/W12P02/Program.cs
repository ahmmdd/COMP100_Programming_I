using System;
/*
 * Part II ‒ Methods that do not return a value but takes an argument:
 */
namespace W12P02{
    class Program{
        #region MAIN
        static void Main(string[] args){
            
            //Question1
            DisplayHorizontalStars(0);
            DisplayHorizontalStars(5);
            DisplayHorizontalStars(10);
            
            //Question2
            DisplayVerticalStars(0);
            DisplayVerticalStars(5);
            DisplayVerticalStars(10);
            
            //Qestion3
            Question3(1);
            Question3(2);
            Question3(10);
            
            //Question4
            Question4(10, "ON");
            Question4(10, "QC");
            Question4(10, "BC");
            
            //Question5
            Question5(11);
            
            //Question6
            Question6(1, 0.5, 20);
            
            //Question7
            Question7(25, 0.2, 5);
            
            //Question8
            Question8(165);
            
        }
        #endregion
        #region Question 1
        /*
 * 1.	
 * Write a method called DisplayHorizontalStars(int numberOfStars). 
 * This method will output the number of stars horizontally 
 * specified by its argument. Call the DisplayHorizontalStars() 
 * method three times from your program Main() method, supplying 
 * 0, 5 and 10 number of stars.
 * 
 * When you invoke these kinds of methods, the value of the parameters 
 * are placed within the pair of brackets and the types are 
 * omitted
 */
        static void DisplayHorizontalStars(int numberOfStars){
            for (int i = 0; i < numberOfStars; i++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
        #endregion
        #region Question 2
/*
 * 2.	
 * Write a method that displays a vertical line of stars. Call 
 * this method, this time with arguments 0, 5 and 10
 */
        static void DisplayVerticalStars(int numberOfStars){
            for (int i = 0; i < numberOfStars; i++){
                Console.WriteLine("*");
            }
        }
        #endregion
        #region Question 3
/*
 * 3.	
 * Write a method that accepts an argument of type double. The 
 * method will calculate and display the volume of the sphere 
 * with radius specified by its argument. [V=4/3(PI)r^3]. Call 
 * this method from your main with arguments 1, 2, and 10. The 
 * answers are 4.1887, 33.5103 and 4188.7902 respectively
 */
        static void Question3(double radius){
            double volume;
            volume = (4.0/3)*Math.PI*radius*radius*radius;
            Console.WriteLine("Radius = {1}\tVolume = {0:f4}", volume, radius);
        }
        #endregion
        #region Question 4
/*
 * 4.	
 * Write a method that takes two arguments: a cost price and a 
 * two letter province code. It will calculate and display the 
 * selling price. (If province is Ontario a tax of 13% is added 
 * to the price, if the province is Quebec a tax of 17% is added 
 * to the cost price. There is no tax for the rest of the 
 * provinces and territories). In your main, call this method 
 * enough times to fully test it
 */
        static void Question4(double cost, string province){
            double tax, totalCost;
            string prov = province.ToLower();
            if (prov == "on"){
                tax = 0.13;
                totalCost = (cost * tax) + cost;
                Console.WriteLine("The total price with tax for {0} is  {1}", province, totalCost);

            }else if (prov == "qc"){
                tax = 0.17;
                totalCost = (cost * tax) + cost;
                Console.WriteLine("The total price with tax for {0} is  {1}", province, totalCost);

            }else{
                totalCost = cost;
                Console.WriteLine("The total price with tax for {0} is  {1}", province, totalCost);
            }
        }
        #endregion
        #region Question 5
/*
 * 5.	
 * Write a method that takes a single argument of type double. 
 * The will display a Celsius to Fahrenheit conversion table. 
 * The starting temperature is indicated by the argument and it 
 * will display 10 lines in increments of 1. In your main call 
 * this method two times.
 */
        static void Question5(double celsius){
            double maxCelsius, fahrenheit, nine, five;
            nine = 9.0;
            five = 5.0;
            maxCelsius = celsius + 10;
            for (double i = celsius; i < maxCelsius; i++){
                fahrenheit = ((celsius * (nine / five)) + 32);
                Console.WriteLine("Celsius: {0}\tFahrenheit: {1:f}", celsius, fahrenheit);
                celsius++;
            }
        }
        #endregion
        #region Question 6
/*
 * 6.	
 * Write a method that takes the following arguments: a starting 
 * km value of type double, an increment size of type double and 
 * the number of lines of type int. The display a kilometer to 
 * miles conversion table. [miles = km * 0.621371]. In your main 
 * call this method three times.
 */
        static void Question6(double km, double incr, int numLines){
            for (double i = km; i < numLines; i += incr){
                double miles = i * 0.621371;
                Console.WriteLine("KM:{0}  Miles: {1}", i, miles);
            }
        }
        #endregion
        #region Question 7
/*
 * 7.	
 * Modify the DisplaySineTable in the previous section to accept 
 * the start value, the step size and number of rows as argument 
 * to the method.
 */
        static void Question7(double startingValue, double stepSize, int numRows){
            double sine;
            Console.WriteLine("Radians\t| Sine");
            Console.WriteLine("--------|--------");
            for (int i = 0; i < numRows; i++){
                sine = Math.Sin(startingValue);
                Console.WriteLine("{0}\t| {1:F4}", startingValue, sine);
                startingValue += stepSize;
            }
        
        }
        #endregion
        #region Question 8
/*
 * 8.	
 * Write a method that converts a person’s height from centimeter 
 * to meters and centimeters and display the result on the 
 * console. In your main method, you should prompt the user for 
 * his height in cm and then call the method with this value.
*/
        static void Question8(double cmHeight){
            double meterHeight;
            meterHeight = cmHeight / 100;
            Console.WriteLine("Height: {0}m", meterHeight);
        }
        #endregion
    }
}
