using System;
using static System.Console;



namespace week10
{
    class Program
    {
        //constants
        const double SNACK_ADULT = 45.5;
        const double SNACK_KIDS = 25;
        const double LUNCH_ADULT = 110;
        const double LUNCH_KIDS = 55;
        const double BRAAI_ADULT = 90;
        const double BRAAI_KIDS = 50;
        const double ENTERTAINMENT = 250;

        public static void Main(string[] args)
        {
            int numberOfAdults;
            int numberOfKids;
            string userChoice;
            int numberOfHoursOfEnt;
            double quote;

            string answer = "Y";
            while(answer == "Y" || answer == "y"){
                GetNumbers(out numberOfAdults, out numberOfKids);

                userChoice = ChooseMenu();
                numberOfHoursOfEnt = SelectEntertainment();
                quote = CalcQuote(numberOfAdults, numberOfKids, userChoice, numberOfHoursOfEnt);

                WriteLine();
                WriteLine("The quote for this function is {0:C}.", quote);
                WriteLine();

                Write("Do you need to calculate another quote: ");
                answer = ReadLine();

                while(answer != "Y" && answer != "y" && answer != "n" && answer != "N" ){
                    Write("Do you need to calculate another quote: ");
                    answer = ReadLine();
                }
            }

        }

        //QUESTION 3A
        public static void GetNumbers(out int numberOfAdults, out int numberOfKids){
            Write("Enter the number of adults: ");
            numberOfAdults = int.Parse(ReadLine());
            Write("Enter the number of kids: ");
            numberOfKids = int.Parse(ReadLine());
        }


        //QUESTION 3B
        public static string ChooseMenu(){
            WriteLine("A: snack plates");
            WriteLine("B: Sit down lunch");
            WriteLine("C: Braai with salads");

            Write("Enter your option (A/B/C): ");
            string choice = ReadLine();

            string choiceUpperCase = choice.ToUpper();

            while(choiceUpperCase != "A" && choiceUpperCase != "B" && choiceUpperCase != "C"){
                Write("Invalid Entry. ");

                WriteLine("A: snack plates");
                WriteLine("B: Sit down lunch");
                WriteLine("C: Braai with salads");

                Write("Enter your option (A/B/C): ");
                choice = ReadLine();

                choiceUpperCase = choice.ToUpper();
            }

            return choiceUpperCase;
        }

        //QUESTION 3C
        public static int SelectEntertainment(){
            int numberOfHours;
            do{
                Write("How many hours of entertainment would you like to include? ");
                numberOfHours = int.Parse(ReadLine());

                if(numberOfHours<0){
                    Console.WriteLine("You have entered an invalid number.");
                }

            }while(numberOfHours < 0 );

            return numberOfHours;
        }

        //QUESTION 3D
        public static double CalcQuote(int numberOfAdults, int numberOfKids, string choice, int numberOfHours){
            double costForAdults;
            double costForKids;
            double costForEntertainment = numberOfHours * ENTERTAINMENT;
            double sum;


            if(choice == "A")
            {
                costForAdults = numberOfAdults * SNACK_ADULT;
                costForKids = numberOfKids * SNACK_KIDS;

            } else if(choice == "B")
            {
                costForAdults = numberOfAdults * LUNCH_ADULT;
                costForKids = numberOfKids * LUNCH_KIDS;
            } else{
                costForAdults = numberOfAdults * BRAAI_ADULT;
                costForKids = numberOfKids * BRAAI_KIDS;

            }

            sum = costForAdults + costForKids + costForEntertainment;

            return sum;
        }

        
    }
}
