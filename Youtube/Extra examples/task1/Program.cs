using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temperatures = new int[10];
            
            ReadIntegers(temperatures);

            int warmestTemp = GetWarmestTemperature(temperatures);
            double average = GetAvgTemperature(temperatures);
            int numberOfWarmDays = CountWarmDays(temperatures);

            Console.WriteLine("The warmest temperature is: {0}", warmestTemp);
            Console.WriteLine("The average temperature is: {0}", average);
            Console.WriteLine("The number of warm days is: {0}", numberOfWarmDays);

            Console.Write("The temperatures in the array are: ");
            DisplayList(temperatures);
        }
        //----------------end of main----------------

        static int GetValidTemperature (int dayNum)
        {
            //prompt user for temperatuire
            Console.Write("Enter temperature for {0}: ", dayNum);
            int temp = int.Parse(Console.ReadLine());

            //If the temperature the user entered is not within acceptable range
            //ask again
            while(temp <0 || temp>=44)
            {
                Console.WriteLine("Invalid Temperature...");
                Console.WriteLine("Enter temperature for {0}", dayNum);
                temp = int.Parse(Console.ReadLine());

            }

            //return the temperature the user entered, after making sure it is valid using a 
            //while loop
            return temp;
        }
        //----------------end of getvalidtemperature--------------------

        //This method(GetWarmest) returns the bigger of the 2 arguments it receives, 
        //the arguments are temp1 and temp2
        static int GetWarmest(int temp1, int temp2)
        {
            //if temp1 is a bigger number, meaning its a warmer temperature in degrees
            //then return temp1
            if(temp1>temp2)
            {
                return temp1;
            } else {
                //if temp1 is not the bigger/warmer number, the temp2 is
                //therefore return temp2
                return temp2;
            }
        }
        //--------------------End of getWarmest--------------------------

        //This will prompt the user to enter a temperature a number of days
        //We use the GetValidTemperature method to get each temperatuire value 
        //from the user
        static void ReadIntegers (int[] list)
        {
            //We run a loop 10 times because the instructions says we
            //are getting temperatures for 10 days
            for(int i=0; i<10; i++)
            {
                list[i] = GetValidTemperature(i);
            }
        }
        //--------------------End of ReadIntegers--------------------------

        //This method will return the biggest value in the array
        static int GetWarmestTemperature(int[] list)
        {
            //we assume the value in index 0 of the array is the biggest
            //then we will compare it to other values in the array
            //if there is a bigger value, the variable warmest will be re-assigned
            //with the value that is bigger
            int warmest = list[0];

            for(int i=1; i<10; i++)
            {
                //each time a value is bigger than warmest. then that value is assigned to
                //warmest.
                if(list[i]>warmest)
                {
                    warmest = list[i];
                } 
            }

            return warmest;
        }
        
        //--------------------End of GetWarmestTemperature--------------------------

        static double GetAvgTemperature(int[] list)
        {
            double sum = 0;
            double average;

            //loop through each element in the array and add its value to sum
            for(int i=0; i<10;i++)
            {
                sum += list[i];
            }

            //only calculate average after summing up the values in the array.
            // careful not to do it inside for loop.
            average = sum/10;

            return average;
        }
        //----------------End of GetAvgTemperature---------------

        //Method counts number of days where temperature is >30
        static int CountWarmDays(int[] list)
        {
            //the number of warm days starts at zero, and increments
            //every time there is a temperature >30 in the array
            int numberOfWarmDays=0;

            for(int i=0; i<10; i++)
            {
                //if the value of the elemt in the array is >30, the increment
                //numberOfWarmDays
                if(list[i]>30)
                {
                    numberOfWarmDays++;
                }
            }

            return numberOfWarmDays;
        }
        //----------------End of GetAvgTemperature---------------

        //Method uses a loop to display values from array
        static void DisplayList(int[] list)
        {
            for(int i=0; i<10; i++)
            {
                Console.Write("{0} ", list[i]);
            }
        }
        //------------------End of DIsplayList------------------

    }
}
