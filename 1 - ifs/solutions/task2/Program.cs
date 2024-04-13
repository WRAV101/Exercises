/*
Write a program that prompts a user to enter 3 numbers
it should then display the biggest number.
*/

// prompt user 3 numbers
// if else statement
// display the biggest number

using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int number = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter the third number: ");
            int number3 = int.Parse(Console.ReadLine());

            if(number > number2 && number > number3)
            {
                Console.WriteLine("{0} is the biggest", number);
                
            } else if(number2 > number && number2 > number3)
            {
                Console.WriteLine("{0} is the biggest", number2);

            } else if(number3 > number && number3 > number2)
            {
                Console.WriteLine("{0} is the biggest", number3);
            }

        }
    }
}
