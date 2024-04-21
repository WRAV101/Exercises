/*
Write a program in C# Sharp to create a user defined function.
Expected Output :
Welcome Friends!
Have a nice day!
*/

// Welcome void
// no parameters

using System;
using static System.Console;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
        }

        
        public static void Welcome(){
            WriteLine("Welcome Friends! \nHave a nice day!");
        }
    }



}

