using System;
/*
 * 10.	
 * Write and run a C# program that calculates and displays the 
 * amount of money available in a bank account that initially has
 * $1,000 deposited in it and that earns 8 percent interest a 
 * year. Your program should display the amount available at the 
 * end of each year for a period of ten years. Use the 
 * relationship that the money available at the end of each year 
 * equals the amount of money in the account at the start of the 
 * year plus .08 times the amount available at the start of the 
 * year.
 */
namespace W08Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            Double totalBalance, rate, interest;
            totalBalance = 1000;
            rate = 0.08;
            Console.WriteLine("  Year  |  Balance");
            Console.WriteLine("========|===========");
            for (int i = 1; i <= 10; i++){
                interest = rate * totalBalance;
                totalBalance += interest;
                Console.WriteLine(" {0}\t| {2:C}", i, interest, totalBalance);
            }
            Console.ReadLine();
        }

    }
}
