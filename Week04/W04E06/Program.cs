/*
 * Name: Mohammed Juned Ahmed
 * Student# 300833356 
 * Date: Jan 27, 2015
 */
using System;
/*
 * 6.	
 * Write a console-based program for a college’s admissions office. The user enters a numeric high 
 * school grade point average (for example, 3.2) and an admission test score. Display the message 
 * “Accept” if the student meets either of the following requirements:
 *      A grade point average of 3.0 or higher and an admission test score of at least 60
 *      A grade point average of less than 3.0 and an admission test score of at least 80
 *      If the student does not meet either of the qualification criteria, display “Reject”. 

 */
namespace W04E06{
    class Program{
        static void Main(string[] args){
            double a = 3.0;
            double b = 60;
            double c = 80;
            Console.Write("Enter your GPA: ");
            double gpa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your Admission Test Score: ");
            double admissionScore = Convert.ToDouble(Console.ReadLine());

            if ((gpa > a && admissionScore <= b)){
                Console.WriteLine("Accept");
            } else if (gpa < a && admissionScore <= c){
                    Console.WriteLine("Accept");
            } else {
                Console.WriteLine("Reject");
            }//end if else block
            Console.ReadLine();
        }//end main
    }//end program
}//end namespace
