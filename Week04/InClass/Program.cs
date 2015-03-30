/*
 * Name: Mohammed Juned Ahmed
 * Student# 300833356 
 * Date: Jan 27, 2015
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Enter question number 1, 2, 3");
            input = Convert.ToInt32(Console.ReadLine());
            if(input == '1'){
                int a = 5; 
                int b = 2; 
                int c = 4;
                int d = 6;
                int e = 3;
                Console.WriteLine("a: {0}" , a > b);
                Console.WriteLine("b: {0}", a != b);
                Console.WriteLine("c: {0}", d % b == c % b);
                Console.WriteLine("d: {0}", a * c != d * b);
                Console.WriteLine("e: {0}", d * b == c * e);
                Console.WriteLine("f: {0}", a * b);
                Console.WriteLine("g: {0}", a % b * c);
                Console.WriteLine("h: {0}", c % b * a);
                Console.WriteLine("i: {0}", b % c * a);
                Console.WriteLine("j: {0}", true || false);
                Console.WriteLine("k: {0}", 7 > 3 && 5 < 2);
                Console.WriteLine("l: {0}", 5 * 4 < 20 || false);
            }
            if (input == '2')
            {
                int a = 5;
                int b = 2;
                int c = 4;
                int d = 5;
                
            }
            //Console.WriteLine(5*4<20 || false);

            Console.ReadLine();
        }
    }
}
