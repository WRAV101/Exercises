/*

Write a program that asks a user for a number
then displays a message saying the number is 
either even or odd.

*/
// prompt the user to enter a number
// then we use the ifs statement to check the number that is even or odd
using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if( num%2 == 0)
            {
                Console.WriteLine("{0} the number is even",num);
            }
            else
            {
                 Console.WriteLine("{0} the number is odd",num);
            }
        }
    }
}
