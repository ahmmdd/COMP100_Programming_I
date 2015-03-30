using System;
/*
 * 5.	
 * To display the numbers 10 … 40 on separate lines with an 
 * asterisk before the multiples of 7. (asterisk besides 
 * multiples)
 */
namespace W07Q05{
    class Program{
        static void Main(string[] args){
            int i = 1;
            do{
                Console.Write("{0}", i);
                if (i % 7 == 0){
                    Console.Write("*\n");
                }else{
                    Console.Write("\n");
                }i++;
            } while (i < 41);
            Console.ReadLine();
        }
    }
}
