/*

Write a program that calculates the roots of a 
quadratic function.

if the root(determinant) is negative no real roots
if its 0. there is only 1 root = -b/2a
if its positive then the roots are (-b+√(b*b-4ac))/2a and (-b-√(b*b-4ac))/2a

*/


//a b c

// we are going to ask user for 3 integers
// ax2 bx c



using System;
using static System.Math;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the value for a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the value for b: ");
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the value for c: ");
            int c = int.Parse(Console.ReadLine());

            double determinant = Math.Pow(b,2) - 4*a*c;

            double root1 = 0;
            double root2 = 0;

            if(determinant < 0)
            {
                Console.WriteLine("UNDEFINED");

            } else if(determinant == 0){
                root1 = -b/2*a;
                root2 = root1;

                
                Console.WriteLine("The roots are: {0} ", root1);
            } else {
                root1 = (-b+Math.Sqrt(b*b-4*a*c))/2*a;
                root2 = (-b-Math.Sqrt(b*b-4*a*c))/2*a;

                Console.WriteLine("The roots are: {0} and {1}", root1, root2);

            }



            
        }
    }
}
