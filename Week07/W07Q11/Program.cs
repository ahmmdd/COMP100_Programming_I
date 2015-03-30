using System;
/*
 * 11.	
 * A machine purchased for $28,000 is depreciated at a rate of 
 * $4,000 a year for seven years. Write and run a C# program that
 * computes and displays a depreciation table for seven years, 
 * The table should have the form: 
 * 
 *                             END-OF-YEAR        ACCUMULATED
 * YEAR      DEPRECIATION        VALUE           DEPRECIATION
 * ----      ------------      ------------      ------------
 *  1            4000            24000               4000
 *  2            4000            20000               8000
 *  3            4000            16000              12000
 *  4            4000            12000              16000
 *  5            4000             8000              20000
 *  6            4000             4000              24000
 *  7            4000                0              28000
*/
namespace W07Q11{
    class Program{
        static void Main(string[] args){
            int year, cost, depreciation, yearEndValue, accumulatedDepreciation;
            cost = 28000;
            depreciation = 4000;
            accumulatedDepreciation = 0;
            Console.WriteLine("                            END-OF-YEAR        ACCUMULATED");
            Console.WriteLine("YEAR      DEPRECIATION        VALUE           DEPRECIATION");
            Console.WriteLine("----\t  ------------\t   ------------\t      ------------");
            year = 1;

            while (year <= 7)
            {
                yearEndValue = cost - (year * depreciation);
                accumulatedDepreciation += depreciation;
                Console.WriteLine(" {0}\t\t{1}\t\t{2}\t\t{3}", year, depreciation, yearEndValue, accumulatedDepreciation);
                year++;
            }

            /*
            do{
                yearEndValue = cost - (year * depreciation);
                accumulatedDepreciation += depreciation;
                Console.WriteLine(" {0}\t\t{1}\t\t{2}\t\t{3}", year, depreciation, yearEndValue, accumulatedDepreciation);
                year++;
            } while (year <= 7);
            */
            /*
            for (year = 1; year <= 7; year++){
                yearEndValue = cost - (year * depreciation);
                accumulatedDepreciation += depreciation;
                Console.WriteLine(" {0}\t\t{1}\t\t{2}\t\t{3}", year, depreciation, yearEndValue, accumulatedDepreciation);
            }
             */
            Console.ReadLine();
        }
    }
}
