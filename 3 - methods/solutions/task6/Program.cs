/*

Redo task 10 from if statements using a method

*/

using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
         {
            
            Console.Write("Enter the value for a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the value for b: ");
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the value for c: ");
            int c = int.Parse(Console.ReadLine());

            Factorize(a, b, c);
        }

        public static void Factorize(int a, int b, int c){
            double determinant = Math.Pow(b,2) - 4*a*c;

            double root1 = 0;
            double root2 = 0;

            if(determinant < 0)
            {
                Console.WriteLine("UNDEFINED");

            } else if(determinant == 0){
                root1 = -b/2*a;
                root2 = root1;

                
                Console.WriteLine("The roots are: {0} ", root1);
            } else {
                root1 = (-b+Math.Sqrt(b*b-4*a*c))/2*a;
                root2 = (-b-Math.Sqrt(b*b-4*a*c))/2*a;

                Console.WriteLine("The roots are: {0} and {1}", root1, root2);

            }
        }
    }
}
