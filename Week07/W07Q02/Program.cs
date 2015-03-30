using System;
/*
 * 2.	
 * To display the numbers 1 … 5 on separate lines
 */
namespace W07Q02{
    class Program{
        static void Main(string[] args){
            int i = 1;
            do{
                Console.WriteLine("{0}", i);
                i++;
            } while (i < 6);
            Console.ReadLine();
        }
    }
}
