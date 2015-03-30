using System;
/*
 * 4.	
 * To display the numbers 1 … 20 on separate lines with an 
 * asterisk next to multiples of 5. (multiples besides asterisk) 
 */
namespace W07Q04{
    class Program{
        static void Main(string[] args){
            int i = 1;
            do{
                Console.Write("{0}", i);
                //int a = i * 5;
                if (i % 5==0){
                    Console.Write("*\n");
                }else{
                    Console.Write("\n");
                }
                i++;
            } while (i < 21);
            Console.ReadLine();
        }
    }
}
