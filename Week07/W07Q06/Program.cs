using System;
/*
 * 6.	
 * To display numbers 20 … 60 on separate lines skipping the 
 * multiple of 3. You must print a blank line for each multiple.
 */
namespace W07Q06{
    class Program{
        static void Main(string[] args){
            int i = 20;
            do{
                if (i % 3 == 0){
                    Console.WriteLine();
                }else{
                    Console.WriteLine("{0}", i);
                }i++;
            } while (i < 61);
            Console.ReadLine();
        }
    }
}
