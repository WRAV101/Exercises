using System;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[6];
            int numberOfNames = 0;

            AddElement(names, ref numberOfNames);
            AddElement(names, ref numberOfNames);
            AddElement(names, ref numberOfNames);
            AddElement(names, ref numberOfNames);
            AddElement(names, ref numberOfNames);

            Console.WriteLine("Display player names... before update");
            display(names, numberOfNames);

            Delete(names, ref numberOfNames);

            
            Console.WriteLine("Display player names... before update");
            display(names, numberOfNames);
            




        }

        public static void Delete(string[] names, ref int numEl)
        {
            Console.Write("Enter an index you want to delete: ");
            int index = int.Parse(Console.ReadLine());

            if(index<0 || index>numEl){
                Console.WriteLine("The index is wrong");
            } else {
                for(int i = index; i<numEl-1; i++)
                {
                    names[i] = names[i+1];
                    numEl--;
                }

            }
        }

        public static void Update(string[] names)
        {
            Console.Write("Enter index you want to update: ");
            int index = int.Parse(Console.ReadLine());

            Console.Write("Enter the new player to replace him with: ");
            names[index] = Console.ReadLine();
        }




        public static void AddElement(string[] names, ref int numEl)
        {
            if(numEl==6){
                Console.WriteLine("The Array is full");
            } else {
                Console.Write("Enter player name: ");
                names[numEl] = Console.ReadLine();

                numEl++;
            }
        }

        public static void display(string[] names, int numEl)
        {
            for(int i=0; i<numEl; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

    }
}
