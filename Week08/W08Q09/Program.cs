using System;
/*
 * 9.	
 * Write a C program that continuously requests a grade to be 
 * entered. If the grade is less than 0 or greater than 100, 
 * your program should print an appropriate message informing 
 * the user that an invalid grade has been entered, else the 
 * grade should be added to a total. When a grade of 999 is 
 * entered the program should exit the repetition loop and 
 * compute and display the average of the valid grades entered.
 */
namespace W08Q09{
    class Program{
        static void Main(string[] args){
            double grade, avg, totAvg = 0, sum = 0;
            for (int i=1; ; i++){
                Console.Write("Enter grade {0}: ",i);
                grade = Convert.ToDouble(Console.ReadLine());
                if (grade >= 0 && grade <= 100){
                    sum += grade;
                    avg = sum / i;
                    totAvg = avg;
                }else if(grade == 999){
                    Console.WriteLine("Total average is {0}",totAvg);
                    break;
                }else{
                    Console.WriteLine("Invalid Input!!!");
                }
            }
            Console.ReadLine();
        }
    }
}
