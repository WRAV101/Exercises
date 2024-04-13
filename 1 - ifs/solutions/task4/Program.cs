/*
Write a Program that asks a user for a number
then displays a message saying whether the number is
divisible by 5 and 11
only divisible by 5 only
only divisible by 11 only
or not divisible by neither
*/

/*
Test data

10      -> divisible by 5 only
15      -> divisible by 5 only

22      -> divisible by 11 only
88      -> divisible by 11 only

55      -> divisible by both
110     -> divisible by both

34      -> divisible by neither
56      -> divisible by neither
*/


//ask a user for 1 number
// then do the checks

using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if((number%5 == 0) && (number%11 == 0))
            {
                Console.WriteLine("divisible by both");
            } else if(number%5 == 0)
            {
                Console.WriteLine("divisible by 5 only");

            } else if(number%11 == 0)
            {
                Console.WriteLine("divisible by 11 only");

            } else {
                Console.WriteLine("not divisible by neither.");

            }
        }
    }
}
