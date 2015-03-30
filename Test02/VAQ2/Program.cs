using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* *******************************************************
 * 
 * Question 2                             
 * while loop                           
 * Executable - Question2A             
 * Name - Mohammed Juned Ahmed
 * Marks - 7                              
 * Print the numbers from a start to an end in specific 
 * increments
 *
 ******************************************************** */
namespace VAQ2{
    class Program{
        static void Main(string[] args){
            int startNum, endNum, steps;
            Console.Write("Enter the start number: ");
            startNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the end number: ");
            endNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the steps amount: ");
            steps = Convert.ToInt32(Console.ReadLine());
            while(startNum < endNum){
                Console.WriteLine(startNum);
                startNum = startNum + steps;
            }
            Console.ReadLine();
        }
    }
}
