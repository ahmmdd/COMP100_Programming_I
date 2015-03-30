using System;
/*
 * 9.	
 * To display the sum of all the multiples of 3 between 
 * 1000000 and 2000000. (Answer = 499,999,500,000). If the sum 
 * might be larger than 2billion then the type of sum should be 
 * a long and not an int.
 */
namespace W07Q09{
    class Program{
        static void Main(string[] args){
            long i, sum;
            sum = 0;
            i = 1000000;
            do{
                if (i % 3 == 0){
                    sum = sum + i;
                }i++;
            } while (i <= 2000000);
            Console.WriteLine("Sum is {0}.", sum);
            Console.ReadLine();
        }
    }
}
