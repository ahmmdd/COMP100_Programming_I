using System;

/* *************************************************************************************
 * Question 5d -> 27 marks
 * Solution    -> Question5d.exe
 * 
 * Name: Mohammed Juned Ahmed
 * Date: Feburary 03, 2015
 * 
 * Purpose: Write a program that calculates the living cost of a student. The prompts the 
 * for two bits of information: if he is living with family and if he is a foreign student.
 * The cost is the sum of the accomodation expenses and tuition fees.
 * 
 * Living Expenses
 * With family -> $1500, without family -> $3000
 * 
 * Tuition Cost
 * Domestic -> $2800, International -> $5400
 * 
 * HINT: 
 *      1)  For maximum marks, you need to use named constants for the two types of tuition
 *      fees and the two types of accomodation expenses i.e. you need four named constants
 *      2)  You must use a pair of nested if's
 *      3)  You need to check for upper and lower cased "y"
 *      2)  See the flowchart for a more detailed description of the calculation
 ************************************************************************************* */
namespace Question5d{
    class Program{
        static void Main(string[] args){
            double livingCost, domesticFee, familyLivingCost,internationalFee, withoutFamilyLivingCost;
            Console.Write("Are you living with family? y/n ");
            char family = Convert.ToChar(Console.ReadLine());
            Console.Write("Are you a foreign student? y/n ");
            char student = Convert.ToChar(Console.ReadLine());

            domesticFee = 2800;
            internationalFee = 5400;
            familyLivingCost = 1500;
            withoutFamilyLivingCost = 3000;
            
            if (student == 'y' || student == 'Y'){
                if (family == 'y' || family == 'Y'){
                    livingCost = internationalFee + familyLivingCost;
                } else if (family == 'n' || family == 'N'){

                }//end family if/else
            } else if (student == 'n' || student == 'N') {
                if (family == 'y' || family == 'Y') {

                } else if (family == 'n' || family == 'N') {

                }//end family if/else
            }//end students if/else
            Console.ReadLine();
        }
    }
}
