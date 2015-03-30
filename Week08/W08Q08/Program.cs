using System;
/*
 * 8.	
 * Write a program to produce a table of numbers from 10 to 1, 
 * with their squares and cubes.
 */
namespace W08Q08
{
    class Program
    {
        static void Main(string[] args)
        {

            double square, cube;
            Console.WriteLine(" Number | Square | Cube ");
            Console.WriteLine("========|========|======");
            for (int i = 10; i > 1; i--)
            {
                square = i * i;
                cube = i * i * i;
                Console.WriteLine("  {0}\t|  {1}\t|  {2}", i, square, cube);
            }
        }
    }
}