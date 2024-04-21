/*

Method that receives a name and age

displays a message with name and age

*/

//method getNameAndAge
//gets 2 arguments, string and int
// void return

using System;
using static System.Console;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            getNameAndAge(21, "Tshepo");
            
        }

        public static void getNameAndAge(string name, int age){
            WriteLine("Name: {0} \nAge: {1}", name, age);
        }
    }
}
