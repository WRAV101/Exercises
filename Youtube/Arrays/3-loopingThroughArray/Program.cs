using System;

namespace loopingThroughArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

            names[0] = "Williams";
            names[1] = "Mokwena";
            names[2] = "Zwane";
            names[3] = "Mudau";
            names[4] = "Morena";

            for(int i=4; i>=0; i--)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine();
        }
    }
}
