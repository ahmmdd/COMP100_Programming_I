using System;

namespace W11ArrayA{
    class Program{
        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        static int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
        static string[] poem = { "Mary", "had", "a", "little", "lamb" };
        static string[] obama = { "Barack", "Houssain", "Obama" };
        static void Main(string[] args){
            //Question1();
            //Question2();
            //Question3();
            //Question4();
            //Question5a();
            Question6();
            Console.WriteLine("SECOND CALL!!!");
            Console.WriteLine(Question6());

        }

        #region Question 1
        /*
 * 1.	
 * Write a method that prints the string array obama. Each 
 * element must be on a separate line. From your main, call this 
 * method. [Your method will not take any parameters and it does 
 * not return a value.]
 * 
 */
        static void Question1(){
            for (int i = 0; i < obama.Length; i++){
                Console.WriteLine(obama[i]);
            }
        }
        #endregion
        #region Question 2
/*
 * 2.	
 * Write a method that prints the string array poem. All the 
 * items must be in the same line. From your main, call this 
 * method. [Your method will not take any parameters and it does 
 * not return a value.]
 */
        static void Question2(){
            for (int i = 0; i < poem.Length; i++){
                Console.Write("{0} ", poem[i]);
            }
        }
        #endregion
        #region Question 3
/*
 * 3.	
 * Write a method that sums all the items and displays the sum of
 * the int array primes. From your main, call this method. [Your 
 * method will not take any parameters and it does not return a 
 * value.]
 * 
 */
        static void Question3(){
            int primeSum = 0;
            for (int i = 0; i < primes.Length; i++){
                primeSum += primes[i];
            }
            Console.WriteLine("Sum of primes is {0}.", primeSum);
        }
        #endregion
        #region Question 4
/*
 * 4.	
 * Write a method that doubles all the items the int array primes
 * From your main, call the previous method, this method and then
 * the previous method again. Because the previous method was 
 * called twice, you will have two printouts, one with the 
 * original value and the second one with the doubled values. 
 * [Your method will not take any parameters and it does not 
 * return a value.]
 */
        static void Question4(){
            Question3();
            int[] primeDouble = new int[primes.Length];
            for (int i = 0; i < primes.Length; i++){
                primeDouble[i] = primes[i] * 2;
            }
            primes = primeDouble;
            Question3();
        }
        #endregion
        #region Question 5
/*
 * 5.a) 
 * Write a method that will subtract 32 from each item of the 
 * char array vowels
 * b) 
 * Write a second method that will display all the items on a 
 * single line of the char array vowels
 * c) 
 * From your main, call the second method, then the first and 
 * then the second again
 * 
 * Subtracting or adding 32 is a common technique for converting 
 * from lower case alphabet to upper case alphabet and vice-versa
 * 
 */
        static void Question5a(){
            for (int i = 0; i < vowels.Length; i++){
                int charToInt = (int)vowels[i];
                int substract = charToInt - 32;
                
                char upperCaseChar = (char)substract;
                //Console.Write("{0} ", upperCaseChar);
                
            }
        }
        static void Question5b()
        {
            //Console.Write(Question5a());
        }
        #endregion

        #region Question 6
/*
 * 6.	
 * Modify your solution for Question 3 so that the method 
 * calculates the sum, but return this value instead of 
 * displaying it. 
 * 
 * From your main, call this new method and display the return 
 * value.
 */
        static int Question6(){
            int primeSum = 0;
            for (int i = 0; i < primes.Length; i++){
                primeSum += primes[i];
            }
            return primeSum;
        }
        #endregion
    }
}
