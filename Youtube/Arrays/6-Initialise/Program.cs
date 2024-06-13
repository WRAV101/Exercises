using System;

namespace Initialise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] IDnumbers = {1111, 7835372, 82729363};
            int numberOfElements = 3;

            display(IDnumbers, numberOfElements);


        }

        public static void display(int[] array, int numEl)
        {
            for(int i=0; i<numEl; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
