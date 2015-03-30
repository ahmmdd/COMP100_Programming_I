using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 1.	Write a method with the following specifications:
name: DisplayMenu
arguments: none
return value: none
tasks: display the following menu choice on the screen

Calculation Menu
1) Calculate Sum 
2) Calculate Sum of Squares
3) Calculate Sum of Cubes
0) To Exit

Enter the number that corresponds to your choice: 

You may beautify the output to your own likings. You don’t have to implement the functionalities of the various menu choices at this stage
Call this method from your main.
2.	Modify your main so that the above method is call repeatedly. The program will terminate when the user enters 0.
3.	Write a method with the following specifications:
name: CalculateSum
arguments: int representing the number of input that will constitute the sum
return value: int representing the sum of its input
tasks: prompt the user for inputs and accumulates the sum of the input. This is repeated as specified by the argument. Returns the final sum 

In your main call this method when the user enters 1 in response to the menu choices. You will invoke this method with argument 10 and display the resulting value.
4.	Write a method with the following specifications:
name: CalculateSumOfSquares
arguments: int representing the number of input that will constitute the sum
return value: int representing the sum of the squares of its input
tasks: prompt the user for inputs and accumulates the sum of the squares of the input. This is repeated as specified by the argument. Returns the final sum 

In your main when the user enters 2 in response to the menu choices, you will prompt the user for the number of inputs that she will be working with. You will invoke this method with this value and display the resulting value.
5.	Write a method with the following specifications:
name: CalculateSumOfCubes
arguments: none
return value: int representing the sum of the cubes of its input
tasks: prompt the user for the number of inputs that she will be working with. Prompts the user for the required number of inputs. Accumulates the sum of the cubes input. Returns the final sum 

In your main when the user enters 3 in response to the menu choices, you will invoke this method and display the resulting value.
6.	Write a method with the following specifications:
name: CalculateAverage
arguments: none
return value: double representing the mathematical average of its inputs
tasks: prompt the user for the number of inputs that she will be working with. Prompts the user for the required number of inputs. Calculate and return the average of the inputs. 

Modify your DisplayMenu method by adding another choice below CalculateSumOfCubes  to In your main when the user enters the appropriate choice in response to the menu choices, you will invoke this method and display the resulting value.
*/
namespace W10Q01{
    class Program{
        static void Main(string[] args){
            for (; ; ){
                Console.Clear();
                DisplayMenu();
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1){
                    Console.Clear();
                    Console.Write("How many number would you like to process? ");
                    int values = Convert.ToInt32(Console.ReadLine());
                    int sum = CalculateSum(values);
                    Console.WriteLine("The Sum is {0}", sum);
                    Console.ReadLine();

                } else if (input == 2) {
                    Console.Clear();
                    Console.Write("How many number would you like to process? ");
                    int values = Convert.ToInt32(Console.ReadLine());
                    int squareSum = SumOfSquares(values);
                    Console.WriteLine("The Sum of Squares is {0}", squareSum);
                    Console.ReadLine();

                } else if (input == 3) {
                    Console.Clear();
                    Console.Write("How many number would you like to process? ");
                    int values = Convert.ToInt32(Console.ReadLine());
                    int cubeSum = SumOfCubes(values);
                    Console.WriteLine("The Sum of Cubes is {0}", cubeSum);
                    Console.ReadLine();

                }else if (input == 4){
                    Console.Clear();
                    Console.Write("How many number would you like to process? ");
                    Double values = Convert.ToInt32(Console.ReadLine());
                    double avg = CalculateAverage(values);
                    Console.WriteLine("The Average is {0}", avg);
                    Console.ReadLine();

                }

                else if (input == 0) { break; }
                else { continue; }
            }
            Console.ReadLine();
        }

        static double CalculateAverage(Double values)
        {
            Double inputNum;
            Double average = 0.0;
            Double sum = 0.0;
            for (Double i = 1; i <= values; i++)
            {
                Console.Write("Enter value #{0}: ", i);
                inputNum = Convert.ToDouble(Console.ReadLine());
                sum += inputNum;
                if (i == values)
                {
                    average = sum / i;
                }
            }
            return average;
        }

        static int SumOfCubes(int numberOfInputs){
            int cubes, cubesSum, inputNum;
            cubesSum = 0;
            for (int i = 1; i <= numberOfInputs; i++){
                Console.Write("Enter value #{0}: ", i);
                inputNum = Convert.ToInt32(Console.ReadLine());
                cubes = inputNum * inputNum * inputNum;
                cubesSum += cubes;
            }
            return cubesSum;
        }

        static int SumOfSquares(int numberOfInputs){
            int squares, squaresSum, inputNum;
            squaresSum = 0;
            for (int i = 1; i <= numberOfInputs; i++){
                Console.Write("Enter value #{0}: ", i);
                inputNum = Convert.ToInt32(Console.ReadLine());
                squares = inputNum * inputNum;
                squaresSum += squares;
            }
            return squaresSum;
        }

        static int CalculateSum(int numberOfInputs){
            int inputNum, sum;
            sum = 0;
            for (int i = 1; i <= numberOfInputs; i++){
                Console.Write("Enter value #{0}: ", i);
                inputNum = Convert.ToInt32(Console.ReadLine());
                sum += inputNum;
                
            }
            return sum;
        }
        static void DisplayMenu(){
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("1) Calculate Sum");
            Console.WriteLine("2) Calculate Sum of Squares");
            Console.WriteLine("3) Calculate Sum of Cubes");
            Console.WriteLine("4) Calculate Average");
            Console.WriteLine("0) To Exit");
        }
    }
}
