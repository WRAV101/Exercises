using System;

namespace task2
{
    class Program
    {
        enum Month
        {
            JANUARY=1, FEBRUARY, MARCH, APRIL, MAY, JUNE,
            JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a month number: ");
            int monthNumber = int.Parse(Console.ReadLine());

            Month monthName = (Month)monthNumber;

            Console.WriteLine("{0} is month number {1}", monthName, monthNumber);
        }
    }
}
