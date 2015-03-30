/*
 * Name: Mohammed Juned Ahmed
 * Student# 300833356 
 * Date: Jan 27, 2015
 */
using System;
/*
 * 9.	
 * To the Lawn application you created in the above question, add a prompt that 
 * asks the user whether the customer wants to pay (1) once, (2) twice, or (3) 
 * 20 times per season. If the user enters 1 for once, the fee for the season 
 * is simply the seasonal total. If the customer requests two payments, each 
 * payment is half the seasonal fee plus a $5 service charge. If the user 
 * requests 20 separate payments, add a $3 service charge per week. Display the 
 * number of payments the customer must make, each payment amount, and the 
 * total for the season.
 * 
 */
namespace W04E09{
    class Program{
        static void Main(string[] args){
            int season = 20;
            double area, length, width, serviceFee, totalFee;
            Double total;
            Console.Write("Enter the Length of the Lawn: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter the Width of the Lawn: ");
            width = Convert.ToDouble(Console.ReadLine());
            area = length * width;
            if (area <= 400){
                serviceFee = 25;
                totalFee = season * serviceFee;
                Console.WriteLine("Mowing Fee (Weekly): {0:C}", serviceFee);
                Console.WriteLine("Mowing Fee (Seasonal): {0:C}", totalFee);
                total = totalFee;
            }else if (area > 400 || area <= 600){
                serviceFee = 35;
                totalFee = season * serviceFee;
                Console.WriteLine("Mowing Fee (Weekly): {0:C}", serviceFee);
                Console.WriteLine("Mowing Fee (Seasonal): {0:C}", totalFee);
                total = totalFee;
            }else if (area > 600){
                serviceFee = 50;
                totalFee = season * serviceFee;
                Console.WriteLine("Mowing Fee (Weekly): {0:C}", serviceFee);
                Console.WriteLine("Mowing Fee (Seasonal): {0:C}", totalFee);
                total = totalFee;
            }
            Console.WriteLine("Payment Options:");
            Console.WriteLine("1.  One payment for the Season.");
            Console.WriteLine("2.  Two payments for the Season.");
            Console.WriteLine("3.  Weekly payments for the Season.");

            int payment = Convert.ToInt32(Console.ReadLine());
            if (payment == 1)
            {
                Console.WriteLine("Your total for the season is {0:C}.", totalFee);
            }else if (payment == 2 ) {
                double a = (totalFee / 2);
                double firstPayment = (totalFee / 2) + 5;
                Console.WriteLine("Your frist payment for the season is {0:C}.", firstPayment);
                double seasonTotal = firstPayment * 2;
                Console.WriteLine("Your total for the season will be {0:C}.", seasonTotal);
            }
            else if (payment == 3){
                double eachPayment = (totalFee / 20) + 3;
                Console.WriteLine("Your weekly payment for the season is {0:C}.", eachPayment);
                double seasonTotal = eachPayment * 20;
            }
            Console.ReadLine();
        }
    }
}
