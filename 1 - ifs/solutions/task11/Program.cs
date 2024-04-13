/*

Write a program that takes a number as input
and displays whether it is in the 10s, 20s, 30s or neither

*/

// ask for number
// check if its in 10s 20s or 30s or neither

using System;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an number: ");
            int number = int.Parse(Console.ReadLine());

            if(number>=40 || number<10)
            {
                Console.WriteLine("The number is neither");
            } else if(number < 20)
            {
                Console.WriteLine("The number is in the 10s");

            } else if(number < 30)
            {
                Console.WriteLine("The number is in the 20s");

            } else if(number < 40)
            {
                Console.WriteLine("The number is in the 30s");

            }
        }
    }
}
