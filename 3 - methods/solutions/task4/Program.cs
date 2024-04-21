/*
Write a program in C# Sharp to create a function for the sum of two numbers.
Test Data :
Enter a number: 15
Enter another number: 16
Expected Output :
The sum of two numbers is : 31
*/


//method called sum
// 2 integer parameters
// return int

using System;
using static System.Console;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter a number: ");
            int number1 = int.Parse(ReadLine());

            
            WriteLine("Enter another number: ");
            int number2 = int.Parse(ReadLine());

            int sumOfnumbers = sum(number1, number2);

            WriteLine("The sum of {0} and {1} is {2}.", number1, number2, sumOfnumbers);

            
        }

        public static int sum(int num1, int num2){
            int sum = num1+num2;

            return sum;
        }

    }
}
