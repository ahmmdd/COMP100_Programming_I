using System;
/*
 * 8.	
 * Same as the previous question but additionally displays the 
 * average of the numbers at the end of the loop 
 */
namespace W07Q08{
    class Program{
        static void Main(string[] args){
            double avg;
            int input;
            int sum = 0;
            int i = 1;
            do{
                Console.Write("Enter a number: ");
                input = Convert.ToInt32(Console.ReadLine());
                sum = sum + input;
                if (i == 1){
                    avg = sum;
                }else{
                    avg = sum / 2;
                }i++;
            } while (sum < 100);
            Console.WriteLine("Sum is {0}\nAverage is {1}", sum, avg);
            Console.ReadLine();
        }
    }
}
