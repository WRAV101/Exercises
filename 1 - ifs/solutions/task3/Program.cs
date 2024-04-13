/*
Write a program that asks a user for a number
then displays a message saying the number is 
either negative, positive or 0.
*/

using System;

//ask user for a number

//dispay a message depending on whether the number is -Ve +ve or 0

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if(number < 0){
                Console.WriteLine("The number is negative. ");
            } else if(number > 0)
            {
                Console.WriteLine("The number is positive.");
            } else {
                Console.WriteLine("The number is zero.");

            }
        }
    }
}
