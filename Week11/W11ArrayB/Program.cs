using System;
/*
Declare the following arrays in your main method 
char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
int[] numbers = {0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2};
string[] poem = "mary had a little lamb its fleece was white as snow".Split();

1.	Write a method that takes an argument (a char array) and 
 * print each item on a single line separated by a space. From 
 * your main, call this method with letters as argument
2.	Write a method that takes an argument (an int array) and 
 * print each item on a single line separated by a space. From 
 * your main, call this method with numbers as argument
3.	Write a method that takes an argument (a string array) and 
 * print each item on a single line separated by a space. From 
 * your main, call this method with poem as argument
4.	In your main method use the Array.Reverse() method to reverse
 * the letters array and then call the appropriate method to 
 * print it
5.	In your main method use the Array.Sort() method to sort the 
 * poem array and then call the appropriate method to print it
6.	In your main method use the Array.Binarysearch() method to t
 * ry to find the position of 3 in the numbers array. What is 
 * your answer?
Now repeat the same steps after you have sorted the array
7.	Write a method that creates and return an array of ints. The 
 * method takes a single argument that represents the number of 
 * items in the resulting array and does the following:
Declare an array of the required type
Allocate memory for the intended number of items
Using any looping structure, assign to each element a random 
 * integer in the range 100 to 200. 
In your main method call this method and display the returned 
 * value.
Radom rand = new Random();
rand.Next(100, 200);

*/
namespace W11ArrayB{
    class Program{
        static void Main(string[] args){
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

        }
    }
}
