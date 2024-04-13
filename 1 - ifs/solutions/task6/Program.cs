/*

Ask a user to enter a year.
Display weather it is a leapyear or not.

-- A leapyear is a year that is divisible by 4 and if it is not a century year
-- and divisible by 400 if it is a century year.

-- Century year 100, 200, ... , 2000, 2100, 2200... 

*/


// ask a user for a year int
// If statements
using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            if((year%4 == 0 && year%100 !=0) || year%400 == 0)
            {
                Console.Write("{0} is a leap year", year);
            }  else 
            {
                Console.Write("{0} is not a leap year", year);

            }


            // Console.Write("Enter a year: ");
            // int year = int.Parse(Console.ReadLine());

            // if(year%4 == 0 && year%100 !=0)
            // {
            //     Console.Write("{0} is a leap year", year);
            // } else if(year%400 == 0) 
            // {
            //     Console.Write("{0} is a leap year", year);
            // } else {
            //     Console.Write("{0} is not a leap year", year);

            // }
        }
    }
}