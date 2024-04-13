/*

Write a program that asks a user for a weekday number
and then display the name of the weekday

*/

//ask user for a weekday number
// dispay the day of the week

using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {

          Console.Write("Enter an week day number: ");
          int weekdayNumber = int.Parse(Console.ReadLine());

      
          Console.WriteLine("Done with if Statements");
          if(weekdayNumber==1){
            Console.WriteLine("{0} is Monday.", weekdayNumber);

          } else if(weekdayNumber==2){
            Console.WriteLine("{0} is Tuesday.", weekdayNumber);

          } else if(weekdayNumber==3){
            Console.WriteLine("{0} is Wednesday.", weekdayNumber);

          } else if(weekdayNumber==4){
            Console.WriteLine("{0} is Thursday.", weekdayNumber);

          } else if(weekdayNumber==5){
            Console.WriteLine("{0} is Friday.", weekdayNumber);

          } else if(weekdayNumber==6){
            Console.WriteLine("{0} is Saturday.", weekdayNumber);

          } else if(weekdayNumber==7){
            Console.WriteLine("{0} is Sunday.", weekdayNumber);
          } else {
            Console.WriteLine("{0} is not a weekday number.", weekdayNumber);
          }

          Console.WriteLine();
          Console.WriteLine("Done with a switch statement");
          
          switch(weekdayNumber) 
          {
            case 1:
              Console.WriteLine("{0} is Monday.", weekdayNumber);
              break;
            case 2:
              Console.WriteLine("{0} is Tuesday.", weekdayNumber);
              break;
            case 3:
              Console.WriteLine("{0} is Wed.", weekdayNumber);
              break;
            case 4:
              Console.WriteLine("{0} is thu.", weekdayNumber);
              break;
            case 5:
              Console.WriteLine("{0} is fri.", weekdayNumber);
              break;
            case 6:
              Console.WriteLine("{0} is sat.", weekdayNumber);
              break;
            case 7:
              Console.WriteLine("{0} is sun.", weekdayNumber);
              break;
            default:
              Console.WriteLine("{0} is not a weekday number.", weekdayNumber);
              break;
          }
          

        }
        
        
    }
}






/*
switch(expression) 
{
  case x:
    // code block
    break;
  case y:
    // code block
    break;
  default:
    // code block
    break;
}
*/
