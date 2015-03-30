using System;
/*
 * 7.	
 * Write a program to produce a table of the numbers 0 through 
 * 20 in increments of 2, with their squares and cubes.
 */
namespace W08Q07{
    class Program{
        static void Main(string[] args){
            double square, cube;
            Console.WriteLine(" Number | Square | Cube ");
            Console.WriteLine("========|========|======");
            for (int i = 0; i < 20; i += 2){
                square = i * i;
                cube = i * i * i;
                Console.WriteLine("  {0}\t|  {1}\t|  {2}", i, square, cube);
            }
            Console.ReadLine();
        }
    }
}
