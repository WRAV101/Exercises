using System;

namespace numberOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] snumbers = new int[8];
            int numberOfElements = 0;

            snumbers[0] = 45;
            numberOfElements++;

            snumbers[1] = 78;
            numberOfElements++;

            for(int i=0; i<numberOfElements; i++){
                Console.WriteLine(snumbers[i]);
            }







            //This part is for me because I use VSCODE
            //For you its Console.Readline()
            Console.WriteLine();
        }
    }
}
