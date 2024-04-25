using System;
using static System.Console;

namespace q32022
{
    class Program
    {
        static void Main(string[] args)
        {
            string vehicle;
            int numberOfDays;
            char choice;
            double income = 0;
            double insurance;
            double amountDue;

            do{
                getDetails(out vehicle, out numberOfDays);
                insurance = getInsurance(vehicle);
                amountDue = calcAmount(vehicle, numberOfDays, insurance);
                WriteLine("The total amount due for this transaction is {0:C}.", amountDue);
                
                income += amountDue;

                Write("Do you want to enter more details: ");
                choice = char.Parse(ReadLine());

            } while(choice == 'Y' || choice == 'y');

            WriteLine("The estimated total income is {0:C}", income);
        }

        public static void getDetails(out string vehicleType, out int days){
            Console.Write("Enter the type of vehicle(...): ");
            vehicleType = ReadLine();
            vehicleType = vehicleType.ToLower();

            Console.Write("Enter the number of days: ");
            days = int.Parse(ReadLine());
        }

        public static double getInsurance(string vehicle){
            char answer;
            double insuranceAmount;

            do{
                Console.Write("Would you like to include insurance(Y/N): ");
                answer = char.Parse(ReadLine());

                answer = Char.ToUpper(answer);
            } while(answer != 'Y' && answer != 'N');

            if(answer == 'Y' && vehicle == "suv"){

                insuranceAmount = 80;
            } else if(answer == 'Y' && vehicle != "suv"){

                insuranceAmount = 50;
            } else {

                insuranceAmount = 0;
            }

            return insuranceAmount;
        }

        public static double calcAmount(string type, int days, double dailyInsurance){
            double total;

            if(type == "suv"){
                double totalInsurance = dailyInsurance * days;
                double totalForRental = days * 300;

                total = totalForRental + totalInsurance;
            } else if(type == "automatic"){
                double totalInsurance = dailyInsurance * days;
                double totalForRental = days * 150;

                total = totalForRental + totalInsurance;
            } else {
                double totalInsurance = dailyInsurance * days;
                double totalForRental = days * 120;

                total = totalForRental + totalInsurance;

            }

            return total;
        }
    }
}
