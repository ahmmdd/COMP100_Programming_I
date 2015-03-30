using System;

namespace MethodDemo{
    class Program{
        static void Main(string[] args){
            DisplayFullName();
            Console.ReadLine();
        }
        static void DisplayFullName(){
            DisplayFirstName();
            Console.Write(" ");
            DisplayLastName();
        }
        static void DisplayFirstName(){
            Console.Write("Mohammed Juned");
        }
        static void DisplayLastName(){
            Console.Write("Ahmed");
        }
        static string GetLastName()
        {
            return "Ahmed";
        }
        static string GetFirstName()
        {
            return "Mohammed Juned";
        }
    }
}
