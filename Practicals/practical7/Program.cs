using System;
using static System.Console;

/*

GetMark 
return type int
receives no arguments


IsPass
return type bool
parameters 1 int called mark


sum
average
number of passes

*/

namespace practical7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            double average;
            int numberOfPasses;

            Write("How many students are in the class: ");
            int numberOfStudent = int.Parse(ReadLine());

            for(int outerIndex=1; outerIndex<= numberOfStudent;outerIndex++){
                sum = 0;
                numberOfPasses = 0;

                for(int innerIndex=1; innerIndex<=5; innerIndex++){

                    int mark = GetMark();
                    bool passed = IsPass(mark);

                    if(passed){
                        numberOfPasses += 1;
                    }
                    sum += mark;
                }

                average = sum/5.0;

                WriteLine();
                WriteLine("Student {0}", outerIndex);
                WriteLine("The sum of the marks: {0}", sum);
                WriteLine("The average of the marks: {0}", average);
                WriteLine("The number of passes: {0}", numberOfPasses);



            }
        }

        public static bool IsPass(int mark){
            if(mark >= 50){
                return true;
            } else {
                return false;
            }

        }

        public static int GetMark() {

            WriteLine("Enter a mark: ");
            int mark = int.Parse(Console.ReadLine());

            while(mark < 0 || mark > 100) {

                WriteLine("{0}, is not a valid mark enter a number between 0 and 100.", mark);
                WriteLine("Enter a mark: ");
                mark = int.Parse(Console.ReadLine());

            }

            return mark;
        }



    }
}