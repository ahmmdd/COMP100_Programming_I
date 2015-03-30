using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 11.	
 * Print the decimal, octal, and hexadecimal values of all 
 * characters between the start and stop characters entered by a 
 * user. For example, if the user enters an a and a z, the 
 * program should print all the characters between a and z and 
 * their respective numerical values. Make sure that the second 
 * character entered by the user occurs later in the alphabet 
 * than the first character. If it does not, write a loop that 
 * repeatedly asks the user for a valid second character until 
 * one is entered.
 */
namespace W08Q11{
    class Program{
        static void Main(string[] args){
            char start, stop;
            int intStart, intStop;
            string oct, hex;
            Console.Write("Enter start charachter: ");
            start = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter stop Charachter: ");
            stop = Convert.ToChar(Console.ReadLine());

            intStart = (int)start;
            intStop = (int)stop;

            if (intStart > intStop){
                for (; ;){
                    Console.Write("Characters Entered are not in Valid Order");
                    stop = Convert.ToChar(Console.ReadLine());
                    intStop = (int)stop;
                    if (intStop > intStart){break;}
                }
            }
            Console.Clear();
            Console.WriteLine("\n =============================================================== ");
            Console.WriteLine("| Charachter\t|   Decimal\t|\tOctal\t| Hexadecimal\t|");
            Console.WriteLine("|---------------|---------------|---------------|---------------|");
            for (int i = intStart; i <= intStop; i++){
                char alphapet;
                oct = Convert.ToString(i, 8);
                hex = Convert.ToString(i, 16);
                alphapet = (char)i;
                Console.WriteLine("|\t{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|", alphapet, i, oct, hex);
            }
            Console.WriteLine(" =============================================================== ");
            Console.ReadLine();
        }
    }
}
