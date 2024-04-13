/*

Write a program that asks a user for an alphabet
then displays weather or not the letter is a 
vowel or a consonent. 

*/

// vowel aeiou

// ask a user for a letter
// check if it is a vowel or consonent

using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an alphabet: ");
            char alphabet = char.Parse(Console.ReadLine());

            if(alphabet=='a' || alphabet=='e' || alphabet=='i' || alphabet=='o' || alphabet=='u'
            || alphabet=='A' || alphabet=='E' || alphabet=='I' || alphabet=='O' || alphabet=='U')
            {
                Console.WriteLine("{0} is a vowel", alphabet);
            } else {
                Console.WriteLine("{0} is a consonent", alphabet);

            }
            
        }
    }
}
