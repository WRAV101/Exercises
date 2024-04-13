/*

A certain grade of steel is graded according to the following conditions

i   - Hardness must be greater than 50
ii  - Carbon content must be less than 0.7
iii - Tensile strength must be greater than 5600

--- --- --- --- --- --- --- --- --- --- --- --- --- --- 

The grades are as follows:

1 - Grade is 10 if all three conditions are met
2 - Grade is 9 if conditions (i) and (ii) are met
3 - Grade is 8 if conditions (ii) and (iii) are met
4 - Grade is 7 if conditions (i) and (iii) are met
5 - Grade is 6 if only one condition is met
6 - Grade is 5 if none of the conditions are met

--- --- --- --- --- --- --- --- --- --- --- --- --- --- 
*/

using System;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the hardness of the steel: ");
            int hardness = int.Parse(Console.ReadLine());

            Console.Write("Enter the Carbon content of the steel: ");
            double carbon = double.Parse(Console.ReadLine());

            Console.Write("Enter the Tensile strength of the steel: ");
            int tensile = int.Parse(Console.ReadLine());

            if((hardness>50) && (carbon<0.7) && (tensile>5600))
            {
                Console.WriteLine("Grade 10");
            } 
            else if((hardness>50) && (carbon<0.7) )
            {
                Console.WriteLine("Grade 9");
            } 
            else if( (carbon<0.7) && (tensile>5600))
            {
                Console.WriteLine("Grade 8");
            } 
            else if((hardness>50) && (tensile>5600)){
                Console.WriteLine("Grade 7");
            } 
            else if((hardness>50) || (carbon<0.7) || (tensile>5600))
            {
                Console.WriteLine("Grade 6");
            } else
            {
                Console.WriteLine("Grade 5");
            } 
        }
    }
}
