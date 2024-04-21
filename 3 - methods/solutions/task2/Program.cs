/*
Write a program in C# Sharp to create a user defined function with parameters.
Test Data :

Please input a name : John
Expected Output :
Welcome friend John !
Have a nice day!
*/

//method called welcome
//return type void
//parameter - string

using System;
using static System.Console;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please input a name : ");
            string username = ReadLine();

            Welcome(username);
        }

        
        public static void Welcome(string name){

            WriteLine("Welcome friend {0} !", name);

        }
    }

}
