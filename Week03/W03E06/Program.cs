using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program to ask the user about the validity of a simple statement. The program should accept the response then 
 * display the statement as well as the response. The response should be true or false. For this question, you must use a 
 * variable of type bool.
 * 
 * Use the Convert.ToBoolean() method to obtain a bool from an input
 */
namespace W03E06{
    class Program{
        static void Main(string[] args){
            string statement = "The weather is beautiful today.";
            Console.WriteLine(statement);
            Console.WriteLine("True or False?");
            bool input;
            input = Convert.ToBoolean(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Statement is: {0}\nResponse is: {1}", statement, input);
            Console.ReadLine();
        }
    }
}
