using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = 5;
            double[] temperatures = new double[numberOfElements];

            GetInfo(temperatures, numberOfElements);
            int userChoice = Menu();

            while(userChoice != 5)
            {
                if(userChoice == 1)
                {
                    GetInfo(temperatures, numberOfElements);
                } else if(userChoice == 2)
                {
                    Console.WriteLine("Temps");
                    DisplayTemps(temperatures, numberOfElements);
                } else if(userChoice == 3)
                {
                    Console.WriteLine("Average");
                    DisplayAverage(temperatures, numberOfElements);
                }
                else if (userChoice == 4)
                {
                    Search(temperatures, numberOfElements);
                } 
                userChoice = Menu();
            }



            Console.ReadLine();
        }

        public static void GetInfo(double[] temperatures, int numberOfElements)
        {
            for (int index = 0; index < numberOfElements; index++)
            {
                Console.Write("Enter the temperature: ");
                temperatures[index] = double.Parse(Console.ReadLine());
            }

        }

        public static void DisplayTemps(double[] temperatures, int numberOfElements)
        {
            Console.WriteLine();
            for (int index = 0; index < numberOfElements; index++)
            {
                Console.Write("{0} ", temperatures[index]);
            }
        }

        public static void DisplayAverage(double[] temperatures, int numberOfElements)
        {

            double sum = 0;
            double average;

            for (int index = 0; index < numberOfElements; index++)
            {
                sum += temperatures[index];
            }
            average = sum / 5.0;

            Console.WriteLine("The average is: {0}", average);
        }

        public static void Search(double[] temperatures, int numberOfElements)
        {

            Console.Write("Enter the temperature to search: ");
            double tempToSearch = double.Parse(Console.ReadLine());

            int position = -1;

            for (int index = 0; index < numberOfElements; index++)
            {
                if (tempToSearch == temperatures[index])
                {
                    position = index;
                }
            }

            if (position == -1)
            {
                Console.WriteLine("The value is not in the array.");
            }
            else
            {

                Console.WriteLine("The value is in index: {0}", position);
            }
        }

        public static int Menu()
        {
            Console.WriteLine("What would you like to do");
            Console.WriteLine("1. Enter a temperature");
            Console.WriteLine("2. Display temperatures in order of entry");
            Console.WriteLine("3. Calculate and display the average");
            Console.WriteLine("4. Search for a temperature, if found, display index position");
            Console.WriteLine("5. quit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            return choice;
        }
    }
}
