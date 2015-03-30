/*
 * Name: Mohammed Juned Ahmed
 * Student# 300833356 
 * Date: Jan 27, 2015
 */
using System;
/*
 * 8.	
 * Write a console-based program for a lawn-mowing service. The lawn-mowing 
 * season lasts 20 weeks. The weekly fee for mowing a lot under 400 square feet 
 * is $25. The fee for a lot that is 400 square feet or more, but under 600 
 * square feet, is $35 per week. The fee for a lot that is 600 square feet or 
 * over is $50 per week. Prompt the user for the length and width of a lawn, 
 * and then display the weekly mowing fee, as well as the total fee for the 
 * 20-week season. 
 * 
 */
namespace W04E08{
    class Program{
        static void Main(string[] args){
            int season = 20;
            
            double area, length, width, serviceFee, totalFee;
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
            }else if (area > 400 || area <= 600){
                serviceFee = 35;
                totalFee = season * serviceFee;
                Console.WriteLine("Mowing Fee (Weekly): {0:C}", serviceFee);
                Console.WriteLine("Mowing Fee (Seasonal): {0:C}", totalFee);
            }else if (area > 600){
                serviceFee = 50;
                totalFee = season * serviceFee;
                Console.WriteLine("Mowing Fee (Weekly): {0:C}", serviceFee);
                Console.WriteLine("Mowing Fee (Seasonal): {0:C}", totalFee);
            }
            Console.ReadLine();
        }
    }
}
