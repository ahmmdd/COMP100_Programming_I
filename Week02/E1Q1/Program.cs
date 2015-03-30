using System;

namespace E1Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, third, average, sum;

            Console.Write("Enter first number: ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter second number: ");
            second = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter third number: ");
            third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();

            sum = first + second + third;
            average = sum / 3;

            Console.WriteLine("Your average is " + average);
        }
    }
}
