/*

Write a Program that asks user for a student's mark for
MATT101, WRAV101 and STAS101

Then display the symbol for the average mark of the 3

75+ A
60+ B
50+ C
49- F

*/


using System;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter mark for MATT101: ");
            int matt = int.Parse(Console.ReadLine());

            Console.Write("Enter mark for WRAV101: ");
            int wrav = int.Parse(Console.ReadLine());
            
            Console.Write("Enter mark for STAS101: ");
            int stas = int.Parse(Console.ReadLine());

            double average = (matt+wrav+stas)/3.0;

            if(average>=75){
                Console.WriteLine("The average symbol is A.");

            } else if(average>=60){
                Console.WriteLine("The average symbol is B.");

            } else if(average>=50){
                Console.WriteLine("The average symbol is C.");

            } else {
                Console.WriteLine("The average symbol is F.");

            }
        }
    }
}
