using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of integers to be entered: ");
            int numIntegers = int.Parse(Console.ReadLine());

            int[] allIntegers = new int[10];

            int[] evenIntegers = new int[10];
            int numOddValues = 0;

            int[] oddIntegers = new int[10];
            int numEvenValues = 0;

            FillArray(allIntegers, numIntegers);

            FillEvenArray(allIntegers, evenIntegers, numIntegers, ref numEvenValues);
            FillOddArray(allIntegers, oddIntegers, numIntegers, ref numOddValues);

            Console.WriteLine();
            Console.WriteLine("Initial numbers: ");
            Display(allIntegers, numIntegers);

            Console.WriteLine();
            Console.WriteLine("Odd numbers: ");
            Display(oddIntegers, numOddValues);

            Console.WriteLine();
            Console.WriteLine("Even numbers: ");
            Display(evenIntegers, numEvenValues);

            Console.ReadLine();
        }

        static void FillArray(int[] list, int numIntegers)
        {
            for(int i=0; i<numIntegers;i++)
            {
                Console.Write("Enter a number: ");
                list[i] = int.Parse(Console.ReadLine());
            }
        }

        static void FillEvenArray(int[] allInts, int[] evenInts, int numAllEl, ref int numEvenEl)
        {
            for(int i=0; i<numAllEl;i++)
            {
                if(allInts[i]%2 == 0)
                {
                    evenInts[numEvenEl] = allInts[i];
                    numEvenEl++;
                }
            }
        }

        static void FillOddArray(int[] allInts, int[] oddInts, int numAllEl, ref int numOddEl)
        {
            for(int i=0; i<numAllEl;i++)
            {
                if(allInts[i]%2 != 0)
                {
                    oddInts[numOddEl] = allInts[i];
                    numOddEl++;
                }
            }
        }

        static void Display(int[] list, int listSize)
        {
            for(int i=0; i<listSize;i++)
            {
                Console.Write("{0} ", list[i]);
            }
        }
    }
}
