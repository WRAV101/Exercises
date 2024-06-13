using System;
/*
Console.WriteLine("1. Add task");
Console.WriteLine("2. Display tasks");
Console.WriteLine("3. Remove task");
Console.WriteLine("4. Quit");
*/



namespace CreatingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = new string[10];
            int numEl = 0;


            DisplayOptions();

            
        }


        

        static int DisplayOptions()
        {
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Display tasks");
            Console.WriteLine("3. Remove task");
            Console.WriteLine("4. Quit");

            int choice;

            do{
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                if(choice < 1 || choice > 4){
                    Console.WriteLine("Invalid Input");
                }
            } while(choice < 1 || choice > 4);

            return choice;
        }


    }
}
