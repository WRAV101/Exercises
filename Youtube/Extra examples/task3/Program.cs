using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            int[] bonus = new int[5];

            GetScores(scores);
            CalcBonus(scores, bonus);
            DisplayAll(scores, bonus);

            Console.ReadLine();
        }
        //----------------end of main----------------

        //Prompt user for scores 5 times to fill an array with 5 elements
        static void GetScores(int[] scores)
        {
            for(int i=0; i<5; i++)
            {
                Console.Write("Enter a score: ");
                scores[i] = int.Parse(Console.ReadLine());
            }
        }
        //----------------end of GetScores----------------

        //Calculate Bonus based on the score in each array element of scores
        //assign the value to the array bonus with the same index
        static void CalcBonus(int[] scores, int[] bonusPoints)
        {
            for(int i=0; i<5;i++)
            {
                if(scores[i] <= 0 || scores[i] > 9)
                {
                    //for invalid scores
                    bonusPoints[i] = 0;

                } 
                else if(scores[i] <= 3)
                {
                    bonusPoints[i] = scores[i] * 10;

                } 
                else if(scores[i] <= 6)
                {
                    bonusPoints[i] = scores[i] * 100;

                } 
                else if(scores[i] <= 9)
                {
                    bonusPoints[i] = scores[i] * 1000;

                } 
            }
        }
        //----------------end of CalcBonus----------------

        static void DisplayAll(int[] scores, int[] bonusPoints)
        {
            Console.WriteLine("Scores");
            for(int i=0; i<5; i++)
            {
                Console.Write("{0} ", scores[i]);
            }

            Console.WriteLine("Bonus");
            for(int i=0; i<5; i++)
            {
                Console.Write("{0} ", bonusPoints[i]);
            }
        }
        //----------------end of DisplayAll----------------
    }
}
