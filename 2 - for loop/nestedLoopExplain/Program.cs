using System;

namespace nestedLoopExplain
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //outer loop
            for(int outerIndex = 5; outerIndex >=1; outerIndex--){

                Console.WriteLine("Starting when index of the outer loop is : {0}", outerIndex);
                
                //inner                         
                for(int innerIndex=1; innerIndex<=5; innerIndex++){
                    Console.Write("{0} ", innerIndex);

                }
                
                Console.WriteLine("\nEnd when index of the outer loop is : {0} \n", outerIndex);
            }
        }
    }
}
