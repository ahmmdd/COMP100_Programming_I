using System;

namespace W12P04{
    class Program{
        static void Main(string[] args){
            #region Questions1-7
            /*
            //Question1
            int x = 4;
            DoubleIt(ref x);
            Console.WriteLine(x);
            
            //Question2
            int cube = 0;
            CubeIt(2, ref cube);
            Console.WriteLine(cube);
            
            //Question3
            double fees = 0.0;
            CaculateTuitionFee(5, 200, ref fees);
            Console.WriteLine(fees);
            double fees1 = 0.0;
            CaculateTuitionFee(5, 100, ref fees1);
            Console.WriteLine(fees1);

            double fees2 = 0.0;
            CaculateTuitionFee(5, 250, ref fees2);
            Console.WriteLine(fees2);

            double fees3 = 0.0;
            CaculateTuitionFee(5, 300, ref fees3);
            Console.WriteLine(fees3);
            
            //Question4
            int s, d;
            Question4(10, 5, out s, out d);
            Console.WriteLine("Sum:{0}  Difference:{1}", s, d);

            int s1, d1;
            Question4(2, 15, out s1, out d1);
            Console.WriteLine("Sum:{0}  Difference:{1}", s1, d1);

            int s2, d2;
            Question4(3, 21, out s2, out d2);
            Console.WriteLine("Sum:{0}  Difference:{1}", s2, d2);
            int s3, d3;
            Question4(6, 6, out s3, out d3);
            Console.WriteLine("Sum:{0}  Difference:{1}", s3, d3);
            
            //Question5
            double angle = 0.500;
            Console.WriteLine(" Angle\t| Sine\t| Cosine");
            Console.WriteLine("--------|-------|-------");
            for (double i = angle; i < 0.510; i = i + 0.001){
                double s, c;
                Question5(i, out s, out c);
                Console.WriteLine(" {0}\t| {1:f3}\t| {2:f3}", i, s, c);
            }
            
            //Question6
            double degree = 0, s, c, t;
            Console.WriteLine(" Degree\t| Sine\t| Cosine| Tangent");
            Console.WriteLine("--------|-------|-------|--------");
            for (double i = degree; i < 100; i += 5){
                CalculateTrigValues(i, out s, out c, out t);
                Console.WriteLine(" {0}\t| {1:f3}\t| {2:f3}\t| {3:f3}", i, s, c, t);
            }
            */
            //Question7
            double sol1, sol2;
            CalculateQuadraticEquationSolutions(12, 1, -6, out sol1, out sol2);
            Console.WriteLine("x= {0:f3}, {1:f3}", sol1, sol2);
            
            #endregion
        }
        #region Question
        #region Question 1
        /*
 * 1.	
 * Write a method call DoubleIt(ref int x) that takes a single 
 * argument and does not return a value. The method will double 
 * the value of its argument
 */
        static void DoubleIt(ref int number){
            number *= 2;
        }
        #endregion
        #region Question 2
/*
 * 2.
 * Write a method call CubeIt(int x, ref int cube) that takes two
 * arguments and does not return a value. The method will cube 
 * the first argument and assign it to the second argument
 */
        static void CubeIt(int x, ref int cube){
            cube = x * x * x;
        }
        #endregion
        #region Question 3
/*
 * 3.
 * Write a method with the following header: static void 
 * CaculateTuitionFee(int numberOfCourses, double costPerCourse, 
 * ref double fees). This method will calculate and assign the 
 * required fees amount to the third argument. [Fees = number of 
 * courses * cost per course + 15.25]. Call the 
 * CaculateTuitionFee() method four times from your program 
 * Main() method supplying different arguments each time and 
 * display the value of the third argument.
*/
        static void CaculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees){
            fees = numberOfCourses * costPerCourse + 15.25;
        }
        #endregion
        #region Question 4
        /*
 * 4.
 * Write a method that takes four parameter of type int. The 
 * method will assign the sum of the first two arguments to the 
 * third and the difference of the first two to the fourth. This 
 * method should be coded so that the calling method will use 
 * the value of the third and fourth parameters. Call this method
 * about three times and print out the value of the four 
 * parameters after the method returns.
*/
        static void Question4(int firstNum,int secondNum,out int sum,out int difference){
            sum = firstNum + secondNum;
            if (firstNum > secondNum){
                difference = firstNum - secondNum;
            }else{
                difference = secondNum - firstNum;
            }
        }
        #endregion
        #region Question 5
        /*
 * 5.
 * Write a method that takes three parameters of type double: the
 * first represents an angle, the other two represents the sine 
 * and cosine of the angle respectively. The method must be able 
 * to change the actual value of the second and third argument. 
 * In your main method call the above method ten times with 
 * values 0.500, 0.501, 0.502 … 0.509 and printout the values 
 * for angle, sine and cosine in a tabular format
*/
        static void Question5(double angle, out double sine, out double cosine){
            sine = Math.Sin(angle);
            cosine = Math.Cos(angle);
        }
        #endregion
        #region Question 6
        /*
 * 6.
 * Write a method with header static void CalculateTrigValues(
 * double degrees, out double sine, out double cosine, out double
 * tangent). The method will use the first argument to compute 
 * the values of the other three arguments. Used the method M
 * ath.Sin, Math.Cos and Math.Tan to compute the second to fourth
 * arguments respectively. [radians = degrees * Math.Pi /180]. 
 * Call this method 20 times with the first argument taking the 
 * values 0, 5, 10, … 95 and display the four arguments in a 
 * professional tabular format.
 */
        static void CalculateTrigValues(double degrees, out double sine, out double cosine, out double tangent){
            double radians = degrees * Math.PI / 180;
            sine = Math.Sin(radians);
            cosine = Math.Cos(radians);
            tangent = Math.Tan(radians);
        }
        #endregion
        #region Question 7
        /*
 * 7.
 * A quadratic equation is one in the form of ax2+bx+c = 0. 
 * Normally, there are two solutions to such [x=(-b∓√(b^2-4ac))/2a].
 * The Write a method that takes five double arguments, the 
 * first three represents a, b and c respectively and the 
 * last two the solutions to the equation. [You can check 
 your implementation, the quadratic equation 12x2+x-6 will 
 * yield solutions -0.750 & 0.667]
 */
        static void CalculateQuadraticEquationSolutions(double a, double b, double c, out double s1, out double s2){
            double determinant = (b * b) - (4 * a * c);
            s1 = (-b + Math.Sqrt(determinant)) / (2 * a);
            s2 = (-b - Math.Sqrt(determinant)) / (2 * a);
        }
        #endregion
        #endregion
    }
}
