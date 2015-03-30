using System;
/*
 * Create a program that prompts the user for her first name, middle initial and last name. The program will display the user 
 * name three times using the following three formats: 
 * 
 * first name, middle initial and last name
 * first name and last name
 * last name, first name and middle initial
 */
namespace UserName{
    class Program{
        static void Main(string[] args){
            //input
            //processing
            //output
            string firstName, middleInitial, lastName;
            //algorithm
            Console.Write("Enter your First mame: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your Middle initial: ");
            middleInitial = Console.ReadLine();
            Console.Write("Enter your Last mame: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Your name is:\n{0} {1} {2}", firstName, middleInitial, lastName);
            Console.WriteLine("{0} {1}", firstName, lastName);
            Console.WriteLine("{2}, {0} {1}", firstName, middleInitial, lastName);

            Console.ReadLine();
        }
    }
}
