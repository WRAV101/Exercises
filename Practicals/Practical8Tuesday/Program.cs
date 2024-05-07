using System;

namespace Practical8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vehicles = new double[5];
            int numberOfVehicles = 0;

            int userChoice = Menu();

            while(userChoice != 5)
            {
                if(userChoice == 1)
                {
                    GetVehicle(vehicles, ref numberOfVehicles);

                } 
                else if( userChoice == 2 && numberOfVehicles > 0)
                {
                    DisplayVehiclePrices(vehicles, numberOfVehicles);
                }
                else if(userChoice == 3 && numberOfVehicles > 0)
                {
                    DisplayAverage(vehicles, numberOfVehicles);
                }
                else if(userChoice == 4 && numberOfVehicles > 0)
                {
                    Search(vehicles, numberOfVehicles);
                }

                if(numberOfVehicles == 0){
                    Console.WriteLine("The array is empty");
                }

                userChoice = Menu();
            }
        }

        public static void GetVehicle(double[] vehicles, ref int num){
            // ask user for a vehicle
            if(num == 5)
            {
                Console.WriteLine("The array is full");

            } else {
                
                Console.Write("Enter vehicle price: ");
                vehicles[num] = double.Parse(Console.ReadLine());
                Console.WriteLine("The price was added to the list.");
                num++;
            }
        }

        public static void DisplayVehiclePrices(double[] vehicles, int numberOfVehicles){
            
            for(int i = 0; i < numberOfVehicles; i++){
                Console.WriteLine("{0:C} ", vehicles[i]);
            }
        }

        public static void DisplayAverage(double[] vehicles, int numberOfVehicles){
            
            double sum = 0;
            double average;

            for(int i =0; i<numberOfVehicles; i++){
                sum += vehicles[i];
            }
            average = sum / numberOfVehicles;

            Console.WriteLine("The Average is: {0:C}", average);

        }

        public static void Search(double[] vehicles, int numberOfVehicles){
            
            Console.WriteLine("Enter a price to search for: ");
            double userPrice = double.Parse(Console.ReadLine());

            int position = -1;

            for(int i=0; i<numberOfVehicles;i++)
            {
                if(userPrice == vehicles[i]){
                    position = i;
                }
            }

            if(position == -1){
                Console.WriteLine("The value was not found in the array.");
            } else {
                Console.WriteLine("The index of the price is {0}", position);
            }
        }



        public static int Menu()
        {
            Console.WriteLine("What would you like");
            Console.WriteLine("1. Enter a vehicle price");
            Console.WriteLine("2. Display vehicle prices in order of entry");
            Console.WriteLine("3. calculate and display average");
            Console.WriteLine("4. Search");
            Console.WriteLine("5. quit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            return choice;
        }
    }
}
