using System;

namespace RefOutDemo
{
    class Program
    {
        // /* OUT DEMO
        // Out doesnt require a value to to be assigned to variables 'a' and 'v'
        // if doing this same example for REF we need to assign 'a=0' and 'v=0'
        static void Main(string[] args)
        {
            double radius = 1;
            double a, v;
            CalculateAreaAndVolume(radius, ref a, ref v);
            Console.WriteLine("R: {0}, A: {1:f}, V: {2:f}", radius, a, v);
            
            Console.ReadLine();
        }

        static void CalculateAreaAndVolume(double rad, ref double area, ref double volume)
        {
            area = 4 * Math.PI * rad * rad;
            volume = 4 * Math.PI * rad * rad * rad / 3;
        }
        // */

         /* REF DEMO= for ref you need to assign value to the variable
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("before calling method -> {0}", a);
            DoubleIt(ref a);
            Console.WriteLine("after calling method -> {0}", a);

            Console.ReadLine();
        }
         static void DoubleIt( ref int number)
        {
            Console.WriteLine("in method before multiplying -> {0}", number);
            number *= 2;
            Console.WriteLine("in method after multiplying -> {0}", number);

        }
          */
    }
}
