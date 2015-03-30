using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 1.	
 * To display five asterisks on a single line. Each asterisk must
 * be separated by a space. You must use a do-while loop to solve
 * this program
 */
namespace W07Q01{
    class Program{
        static void Main(string[] args){
            int i = 0;
            do{
                Console.Write("* ");
                i++;
            } while (i < 5);
            Console.ReadLine();
        }
    }
}
