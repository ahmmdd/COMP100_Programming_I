using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading name and the reading salary as string then displaying 
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("\nWhat is your Annual Salary?\n");
            /* string salary = Console.ReadLine();
             Console.Clear();
             Console.Write("Hello " + name + ", Your annual salary is " + salary + "\n\n");
             */


            //reading name as string and the reading salary as integer then displaying

            int salary = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Hello " + name + ", \nYour annual salary is " + salary + ".\nYour monthly salary is " + salary / 12 + ".\n\n");
        }
    }
}
