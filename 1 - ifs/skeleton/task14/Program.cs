/*



*/

using System;

namespace task14
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileAndFor();

            Console.WriteLine();
        }

        public static void WhileAndFor()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            while(num > 0)
            {
                for(int i=0; i<num; i++)
                {
                    Console.Write("{0} ", i);
                }

                Console.WriteLine();
                Console.Write("Enter another number: ");
                num = int.Parse(Console.ReadLine());
            }
        }

        
        public static void stars2() {

            for(int i=0; i<5; i++)
            {
                for(int j=5; j>i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
                // *****
                // ****
                // ***
                // **
                // *

            }
        }

        public static void stars1()
        {
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                // *
                // **
                // ***
                // ****
                // *****

            }
        }

        public static void Loops()
        {
            for(int i = 0; i< 3; i++)
            {
                for(int j =0; j< 3;j++)
                {
                    Console.Write("({0}, {1}) - ", i, j);
                }
                Console.WriteLine();
            }
        }
    }
}
