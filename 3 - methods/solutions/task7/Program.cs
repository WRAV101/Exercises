/*

Write a function that checks if a number is a prime number or not
use it in the main function to diplay a message to user

*/

//method call isPrime
// bool return
// int

using System;
using static System.Console;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsANumberPrime = IsPrime(21);

            if(IsANumberPrime){
                WriteLine("Prime number");
            } else {
                WriteLine("Not a prime number");
            }
          
        }

        public static bool IsPrime(int number){
            bool isPrime = true;

            for(int i=2; i<number; i++){
                if(number%i == 0){
                    isPrime = false;
                }
            }

            if(isPrime){
                return isPrime;
            } else {
                return isPrime;
            }

        }
    }
}
