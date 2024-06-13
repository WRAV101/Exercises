using System;



namespace AddTask
{
    class Program
    {
         static void Main(string[] args)
        {
            string[] list = new string[10];
            int numEl = 0;
            int choice;
            do{
                choice = DisplayOptions();

                if(choice == 1)
                {
                    AddTask(list, ref numEl);
                } 
                else if( choice == 2)
                {
                    DisplayTasks(list, numEl);
                }
                else if( choice == 3)
                {
                    RemoveTask(list, ref numEl);
                }


            } while(choice !=4);


        }

        static void RemoveTask(string[] todoList, ref int numEl)
        {
            if(numEl==0)
            {
                Console.WriteLine("There are no elements to remove.");
            } else {
                Console.Write("Enter the element you want to remove: ");
                string wanted = Console.ReadLine();

                int position = FindTask(todoList, numEl, wanted);

                if(position == -1)
                {
                    Console.WriteLine("The item is not in the list");
                } else {

                    for(int i = position; i<numEl-1; i++)
                    {
                        todoList[i] = todoList[i+1];
                    }
                    
                    numEl--;
                }

            }
        }


        static int FindTask(string[] todoList, int numEl, string wanted)
        {
            int position = -1;
            for(int i =0; i<numEl; i++)
            {
                if(todoList[i] == wanted)
                {
                    position = i;
                }
            }

            return position;
        }

        static void DisplayTasks(string[] todoList, int numEl)
        {
            if(numEl>0){
                for(int i=0; i<numEl; i++)
                {
                    Console.WriteLine(todoList[i]);
                }
            } else {
                Console.WriteLine("No tasks found");
            }
        }


        static void AddTask(string[] todoList, ref int numEl)
        {
            if(numEl==10){
                Console.WriteLine("The Array is full");
            } else {
                Console.Write("Enter a task: ");
                todoList[numEl] = Console.ReadLine();

                numEl++;
            }

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
