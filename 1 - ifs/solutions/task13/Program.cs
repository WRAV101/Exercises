/* 

Ask a user for a number
then display the absolute value of the number


--- --- --- --- --- --- --- --- --- --- --- --- --- --- 
Format of output
---
"Absolute value of userInput is: absoluteValue"
--- --- --- --- --- --- --- --- --- --- --- --- --- --- 
*/

using System;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if(number >= 0){
                Console.WriteLine("The absolute value of the number is {0}",number);
            }
            else{
                Console.WriteLine("The absolute value of the number is {0}",number * -1);
            }

        }
    }
}
