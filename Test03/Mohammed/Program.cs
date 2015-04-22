/*
 ********************************************************************************
 *
 * Name: Mohammed Juned Ahmed
 * Date: April 14, 2015
 * Student #: 300833356
 * Test 3 - 20% of final grade
 * 
 ******************************************************************************** 
 */

using System;

namespace Mohammed{
    class Program{
        #region MAIN
        static void Main(string[] args){
            for (; ; ){
                Introduction();
                char input = Convert.ToChar(Console.ReadLine());
                if (input == 'I' || input == 'i'){
                    DemoQuestion3();
                }else if(input == 'B' || input == 'b'){
                    DemoQuestion4();
                }else if(input == 'H' || input == 'h'){
                    DemoQuestion5();
                }else if(input == 'M' || input == 'm'){
                    DemoQuestion6();
                }else if(input == 'X' || input == 'x'){
                    break;
                }else{
                    Console.WriteLine("Error Invalid Input!!!! Try Again.");
                    continue;
                }
            }
        }
        #endregion
        #region Helper
        /* Helper method for question 3 */
        static int[] GenerateRandomIntegers(int numberOfItems){
            int[] result = new int[numberOfItems];
            Random rand = new Random();
            for (int i = 0; i < result.Length; i++)
                result[i] = rand.Next(10);
            return result;
        }


        /* Helper method for question 3 */
        static void PrintIntArray(int[] array){
            foreach (var x in array)
                Console.Write("{0} ", x);
            Console.WriteLine();
        }
        #endregion
        #region Part 1 & Part 2 – Question 1
        /* Question 1 (13 marks)
         * 
         * Write a method that does not take any argument nor does it
         * return a value. The method only displays the following text.
         * 
         * ----------------------COMP100-062---------------------
         *             I) Working with array of integers");
         *             B) Working with Boltzman equation");
         *             H) Working with Hyperbolic functions");
         *             M) Working with Mortgage");
         *                                                       
         *             X) To exit the program");
         * ------------------------------------------------------
         * Press the letter corresponding to your choice-> ");
         * 
         * In your Main() method, write the code to call this method continuously
         * You must implement all the functionality for all valid responses. Valid
         * responses includes both upper and lower case of the input. The following
         * must be implemented:
         * I will call the DemoQuestion3() method
         * B will call the DemoQuestion4() method
         * H will call the DemoQuestion5() method
         * M will call the DemoQuestion6() method
         * X will terminate the program
         * Any other key will produce an error message
         */
        static void Introduction(){
            Console.WriteLine("----------------------COMP100-062---------------------");
            Console.WriteLine("            I) Working with array of integers");
            Console.WriteLine("            B) Working with Boltzman equation");
            Console.WriteLine("            H) Working with Hyperbolic functions");
            Console.WriteLine("            M) Working with Mortgage");
            Console.WriteLine();
            Console.WriteLine("            X) To exit the program");
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Press the letter corresponding to your choice-> ");

        }
#endregion
        #region Part 3 – Question 3 (Working with arrays)
        /* Question 3 (13 marks)
         * 
         * Write a method that take an array of integer and 
         * returns a count of all the even elements. The specifications is 
         * as follows:
         * 
         * Name:
         *  CountEvens
         *  
         * Argument: 
         *  an array of ints
         *  
         * Returns:
         *  an integer representing the number of even numbers in the argument
         *  
         * Action:
         *  Counts and return the number of evens in the array. You may use the
         *  modulus operator to check for evenness. (You may assume that 0 is even)
         *  
         * Displays:
         *  nothing
         * 
         * 
         * In the DemoQuestion3() method, write the code to do the following:
         * 1) declare a variable of type int array and assign to it the 
         *    value of calling the GenerateRandomIntegers() with argument 20
         * 2) Using the PrintIntArray() method display the above variable.
         * 3) Using the CountEvens() count the evens of the variable
         *    in step 1.
         * 3) Display the result of step 3. 
         */

        /* The driver for question 3 */
        static void DemoQuestion3(){
            Console.WriteLine("\n\n**********Begin Question 3 **********");
            //code for invoking question 3 goes here
            int[] array = GenerateRandomIntegers(20);
            PrintIntArray(array);
            int counter = 0;
            for (int i = 1; i < array.Length; i++){
                counter += CountEvens(array[i]);
            }
            Console.WriteLine("There are {0} evens in the above array.", counter);
            Console.WriteLine("\n**********End Question 3 **********\n\n");

        }
        static int CountEvens(int array){
            int evens = 0;
            if ((array % 2) == 0){
                evens++;
            }else { }
            return evens;
        }
#endregion 
        #region Part 4 – Question 4
        /* Question 4 (13 marks)
         * 
         * Write a method that calculates and return the energy emitted
         * by a hot body. The specifications is as follows:
         * 
         * Name:
         *  Boltzman
         *  
         * Argument: 
         *  a double representing the absolute temperature of the body
         *  
         * Returns:
         *  a double indicating the total energy emitted
         *  
         * Action:
         *  calculates and return the energy emitted
         *  by a hot body. The equation will be writen on the whiteboard
         *  
         * Displays:
         *  nothing.
         * 
         * In the DemoQuestion4() method, write the code to call this method two
         * times with arguments 279 and 5778 respectively and display the return
         * value after each call
         */

        /* The driver for question 4 */
        static void DemoQuestion4(){
            Console.WriteLine("\n\n**********Begin Question 4 **********");
            //code for invoking question 4 goes here
            Console.WriteLine("{0:f1}J", Boltzman(279));
            Console.WriteLine("{0:f1}J", Boltzman(5778));
            
            Console.WriteLine("\n**********End Question 4 **********\n\n");
        }
        static double Boltzman(double tempetature){
            double E;
            double sigma = 5.67e-8;
            E = sigma * (tempetature * tempetature * tempetature * tempetature);
            return E;
        }
#endregion
        #region Part 5 – Question 5
        /* Question 5 (13 marks)
         * 
         * Write a method that calculates the hyperbolic sin and tan
         * of a given angle. The specifications is as follows:
         * 
         * Name: 
         *  Hyperbolic
         * 
         * Argument: 
         *  a double representing the angle in radianm
         *  a double representing the sinh of the first argument
         *  a double representing the tanh of the first argument
         *  
         * Returns:
         *  nothing
         *  
         * Action:
         *  Calculates the sinh and tanh of the first argument and
         *  assign the values to the second and third arguments
         *  respectively.
         *  The sinh and tanh are obtained by the Math.Sinh() and
         *  the Math.Tanh() methods respectively
         *  
         * Displays:
         *  nothing.
         * 
         * 
         * In the DemoQuestion5() method, write the code to call this method 10
         * times with argument starting at 1.0 and increasing by 0.2 each cycle
         * You should display the three arguments in a table format
         */
        /* The driver for question 5 */
        static void DemoQuestion5(){
            Console.WriteLine("\n\n**********Begin Question 5 **********");
            //code for invoking question 5 goes here
            Console.WriteLine("Radians\t| Sinh  | Tanh ");
            Console.WriteLine("--------|-------|--------");
            double rad = 1.0, sinh, tanh;
            for (int i = 0; i < 10; i++){
                Hyperbolic(rad, out sinh, out tanh);
                Console.WriteLine(" {0:F1}\t| {1:F4}| {2:F4}", rad, sinh, tanh);
                rad += 0.2;
            }
            Console.WriteLine("\n**********End Question 5 **********\n\n");
        }
        static void Hyperbolic(double angle, out double sinh, out double tanh){
            sinh = Math.Sinh(angle);
            tanh = Math.Tanh(angle);
        }
        
        #endregion
        #region Part 6 – Question 6
        /* Question 6 (13 marks)
         * 
         * Write a method that calculates and return the balance on a mortgage.
         * The balance is obtained by adding the accrued interest and subtracting
         * the payment.
         * The accrued interest is the daily interest times the number of days in
         * the payment cycle.
         * The daily interest is the principle multiplied by the interest rate
         * divided by the number of days in the year (365 or 366). The 
         * specifications is as follows:
         * 
         * Name: 
         *  CalculateBalance
         * 
         * Argument: 
         *  a double representing the starting principle
         *  a double representing the annual interest rate
         *  a double representing the payment
         *  an int representing the number of days between payments
         *  a bool indicating if this year is a year year or not
         *  
         * Returns:
         *  a double representing the ending principle
         *  
         * Action:
         * 1)
         *  Calculates the daily interest:
         *  for year year -> starting Principle * annual interest rate / 36600;
         *  for normal year -> starting Principle * annual interest rate / 36500;
         *  respectively.
         * 2)
         *  calculates interest:
         *  daily interest * number of days between payments
         * 3) 
         *  Calculates ending balance:
         *  starting principle + interest - payment
         * 4) 
         *  returns ending balance
         *  
         * Displays:
         *  nothing.
         * 
         * 
         * In the DemoQuestion6() method, write the code to call this method 12
         * times. The first call is made with arguments 350000, 3.0, 2000, 28
         * and true. For subsequent call the first argument is replaced by the
         * returned value of the previous method call. You should display the
         * ending principle after each method call
         */
        /* The driver for question 6 */
        static void DemoQuestion6(){
            Console.WriteLine("\n\n**********Begin Question 6 **********");
            //code for invoking question 6 goes here
            double startP=350000;
            double rate=3.0;
            double paid=2000;
            int diff=28;
            for (int i = 1; i <= 12; i++){
                double a = CalculateBalance(startP, rate, paid, diff, true);
                Console.WriteLine("At the end of period #{0} the principle is {1:C}", i, a);
                startP = a;
            }                
            Console.WriteLine("\n**********End Question 6 **********\n\n");
        }
        static double CalculateBalance(double startPrinciple, double annualRate, double payment, int numDaysBetweenPayments, bool year){
            double dailyInterest, endingBalance, interest;
            if (year == true){
                dailyInterest = startPrinciple * annualRate / 36600;
            }else{
                dailyInterest = startPrinciple * annualRate / 36500;
            }
            interest = dailyInterest * numDaysBetweenPayments;
            endingBalance = startPrinciple + interest - payment;
            return endingBalance;
        }
        #endregion
    }
}
