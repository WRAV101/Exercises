/*
Write a program that prompts a user to enter 2 numbers
it should then display the bigger number.
*/

using System;

// promt a user 2X
// 2 variables

// if statement to compare the variables
// then Display the bigger number

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int number2 = int.Parse(Console.ReadLine());

            if(number1 > number2)
            {
                Console.WriteLine("{0} is bigger than {1}", number1, number2);
            } else if(number2 > number1)
            {
                Console.WriteLine("{0} is bigger than {1}", number2, number1);
            } else 
            {

                Console.WriteLine("The numbers are equal");
            }
        }
    }
}