using System;
/*
 * 3.	
 * To display the numbers 1 … 20 on separate lines
 */
namespace W07Q03{
    class Program{
        static void Main(string[] args){
            int i = 1;
            do{
                Console.WriteLine("{0}", i);
                i++;
            } while (i < 21);
            Console.ReadLine();
        }
    }
}
