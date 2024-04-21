/*

Write a program in C# to create a function to swap two integer numbers.
Test Data :
Enter a number: 5
Enter another number: 6
Expected Output :
Now the 1st number is : 6 , and the 2nd number is : 5

*/

//method called swop
//take 2 numbers as arguments int and int
//


using System;
using static System.Console;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 3;
            int number2 = 67;

            swop( number1, number2);

            
            WriteLine("Back in main function...");
            WriteLine("Number1: {0}", number1);
            WriteLine("Number2: {0}", number2);
            
            
        }


        public static void swop(int number1, int number2){
            int temp;

            WriteLine("Number1: {0}", number1);
            WriteLine("Number2: {0}", number2);

            WriteLine();
            WriteLine("Swop the values");

            temp = number1;
            number1 = number2;
            
            WriteLine("Number1: {0}", number1);
            WriteLine("Number2: {0}", number2);
            WriteLine();

            number2 = temp;

            
            WriteLine("Number1: {0}", number1);
            WriteLine("Number2: {0}", number2);

        }


    }
}
