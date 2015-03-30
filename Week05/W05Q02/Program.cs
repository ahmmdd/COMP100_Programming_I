using System;

/*
 * Write a program that allows the user to enter two integers and
 * a character If the character is A, add the two integers If it 
 * is S, subtract the second integer from the first if it is M, 
 * multiply the integers Display the results of the arithmetic
 */
namespace W06Q02{
    class Program{
        static void Main(string[] args){
            int firstNumber, secondNumber, result;
            string operation;

            Console.Write("The first numer: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("The second numer: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("The operation A/S/M? ");
            operation = Console.ReadLine().ToLower();

            switch (operation){
                case "a":
                    result = firstNumber + secondNumber;
                    break;
                case "s":
                    result = firstNumber - secondNumber;
                    break;
                case "m":
                    result = firstNumber * secondNumber;
                    break;
                default:
                    result = -1;
                    break;
            }
            if (result == -1) {
                Console.WriteLine("Error Occured. Invalid operation!!");
            } else {
                Console.WriteLine("The result of your arthemetic is {0}.", result);
            }
            Console.ReadLine();
        }
    }
}
