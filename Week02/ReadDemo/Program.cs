using System;

namespace ReadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            String name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nYour Name is " + name + "\n");
        }
    }
}
