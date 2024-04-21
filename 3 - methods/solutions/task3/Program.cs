/*
Write a your own power function.

*/

//pow(2,3);
//power
//2 integer values
// return int

using System;
using static System.Console;
using static System.Math;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter base: ");
            int b = int.Parse(ReadLine());

            
            WriteLine("Enter exponent: ");
            int e = int.Parse(ReadLine());


            int number = power(b,e);

            WriteLine("Using Our metdhod");
            WriteLine("{0} to the power {1} is: {2}", b, e, number);

            
            double numberUsingLibrary = Math.Pow(b,e);

            WriteLine("Using Our Math Library");
            WriteLine("{0} to the power {1} is: {2}", b, e, numberUsingLibrary);
            
        }

        
        public static int power(int b, int exp){
            int product = 1;

            for(int i=1; i<=exp; i++){
                product = product * b;
            }
            return product;
        }
    }

}
