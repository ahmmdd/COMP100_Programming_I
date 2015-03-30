using System;
/*
 * 7.	
 * To prompt for a number and sum it. When the sum just exceeds 
 * 100, stop the prompting and display the sum at the end. You 
 * must not display the sum while the user in typing in numbers. 
 * (You do not need a counter but you will need some way of 
 * terminating the loop)
 */
namespace W07Q07{
    class Program{
        static void Main(string[] args){
            int input;
            int sum = 0;
            do{
                Console.Write("Enter a number: ");
                input = Convert.ToInt32(Console.ReadLine());
                sum = sum + input;
            } while (sum < 100);
            Console.WriteLine("Sum is {0}", sum);
            Console.ReadLine();
        }
    }
}
