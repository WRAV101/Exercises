/* 

*/

using System;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            starsReverse();
            Console.WriteLine();
        }

        
        // *****
        // ****
        // ***
        // **
        // *
        public static void starsReverse() {
            for(int i=0; i<5; i++)
            {
                for(int j=5; j>i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        // *
        // **
        // ***
        // ****
        // *****
        public static void stars()
        {
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.Write(j+1);
                }
                Console.WriteLine();
            }

        }




        // How Indexes of nested loops work
        public static void LoopIndex()
        {
            for(int i =0; i<5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }
    }
}
