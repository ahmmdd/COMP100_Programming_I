using System;

namespace W12P05{
    class Program{
        static void Main(string[] args){
            /*
            //Question1
            int[] array = { 0, 1, 6, 2, 2, 0, 8, 0, 3, 2 };
            PrintIntArray(CalculateDigitFrequencies(array));
            
            //Question2
            int[] arra = { 7, 5, 10, 15, 14, 17, 25, 26, 22, 23, 21, 29, 30, 53, 42, 37, 38, 44, 46, 58, 94 };
            PrintIntArray(CalculateNumberFrequencies(arra));
            */
            //Question3

            //Question4
            string[] arry = { "7", "128", "15" };
            PrintStringArray(BinaryString(arry));

            
            #region 1
        }
    static void PrintStringArray(string[] array){
            for (int i = 0; i < array.Length; i++){
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
        #region Print Integer Array
        static void PrintIntArray(int[] array){
            for (int i = 0; i < array.Length; i++){
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
        #endregion
        #region Question 1
        /* 1.	
 * Write a method with header static int[] 
 * CalculateDigitFrequencies(int[] array). The argument is an int
 * array with values ranging from 0 to 9. The returned value is 
 * an array of 10 integers. The elements of the return array will
 * be a count of the frequencies of the items in the argument. 
 * The first element of the returned array represents the number 
 * of 0’s in the argument, the second element indicates the 
 * number of 1’s in the argument and the third element will 
 * indicate the number of 2’s in the argument.
 * 
 * The method will create an int array of 10 elements (call this the
 * result). Each item of the argument is examined and the 
 * appropriate element of the result array is incremented. In 
 * your main method, create an int array and print out the 
 * elements. Call the above method and display the return value. 
 * Do a count to verify that your method is working correctly.
 */
        static int[] CalculateDigitFrequencies(int[] array){
            //int[] counter = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] counter = new int[10];
            for (int i = 0; i < array.Length; i++){
                counter[array[i]]++;
                /*
                if (array[i] == 0){ counter[0] += 1;}
                else if (array[i] == 1){ counter[1] += 1;}
                else if (array[i] == 2){ counter[2] += 1;}
                else if (array[i] == 3){ counter[3] += 1;}
                else if (array[i] == 4){ counter[4] += 1;}
                else if (array[i] == 5){ counter[5] += 1;}
                else if (array[i] == 6){ counter[6] += 1;}
                else if (array[i] == 7){ counter[7] += 1;}
                else if (array[i] == 8){ counter[8] += 1;}
                else if (array[i] == 9){ counter[9] += 1;}
                else { }
                */
            }
                return counter;
        }
        
        #endregion
        #region Question 2
/*
 * 2.	
 * Write a method with header static int[] 
 * CalculateNumberFrequencies(int[] array). The argument is an 
 * int array with values ranging from 0 to 99. The returned value
 * is an array of 10 integers. The first element will indicate 
 * the number or unit values in the argument (i.e. values 0-9), 
 * the second element will indicate the number of 10 values (i.e.
 * values 10-19), the third element will indicate the number of 
 * 20 values (i.e. values 20-29) etc.
 * 
 * The method will create an int array of 10 elements (call this 
 * the result). Each item of the argument is examined and the 
 * appropriate element of the result array is incremented. In 
 * your main method, create an int array and print out the 
 * elements. Call the above method and display the return value. 
 * Do a count to verify that your method is working correctly.
 */
        static int[] CalculateNumberFrequencies(int[] array){
            int[] counter = new int[10];
            foreach (int num in array){
                counter[num / 10]++;
            }
            return counter;
        }

        #endregion
        #region Question 3
/*
 * 3.	
 * Write a method that takes a string and return a distribution 
 * of the letter in the string. A distribution can be an array of
 * the letter frequencies. Call the above method and display the 
 * return value. Do a count to verify that your method is working
 * correctly.
*/
        #endregion
            #endregion
        #region Question 4
        /*
 * 4.	
 * Write a method that returns a binary string representation of 
 * its argument. Call this method from your main and display the 
 * returned values. The integers 7 , 128, 15 will return binary 
 * string 111, 10000000, 1111 respectively
 */
        static string[] BinaryString(string[] array)
        {
            int a = array.Length;
            string[] binaryString = new string[a];
            for (int i = 0; i < a; i++ )
            {
                string binary = Convert.ToString(Convert.ToInt32(array[i]),2);
                binaryString[i] = binary;
            }

            return binaryString;
        }
        #endregion
        #region Question 5
/*
 * 5.	
 * Write a method that will compute the year-end balance for a 
 * mortgage, given the beginning balance, the yearly interest 
 * rate, and the bi-weekly payments. You can assume that there 
 * are 26 payments in the year and the mortgage is re-calculated 
 * after each payment. If the starting principal is $300,000, the
 * interest rate is 2.5% and the monthly payment is $1,000, what 
 * will be the year-end balance? How much would you save if you 
 * increased the monthly payment by $100?
 */
        #endregion
        #region Question 6
/*
 * 6.	
 * Write a method that will display the nth term of a Fibonacci 
 * sequence. The nth term is defined as the sum of the two 
 * previous terms. The first few terms of the Fibonacci series 
 * are 1, 1, 2, 3, 5, 8, 13, 21, etc.
 */
        #endregion
        #region Question 7
/*
 * 7.	
 * Write a method that will return the factorial of its argument 
 * number. [n! = n(n-1)(n-2)(n-3)… (1)] 
 */
        #endregion
        #region Question 8
/*
 * 8.	
 * Write a method that takes two integers and returns the 
 * greatest common divisor (gcd).
 */
        #endregion
        #region Question 9
/*
 * 9.	
 * Write a method similar to question 3, that counts the 
 * distribution of two-letters combinations i.e. diagrams
 */
        #endregion
    }
}
