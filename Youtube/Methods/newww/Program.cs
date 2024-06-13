using System;

namespace newww
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] swimmerNames = new string[10];
            double[] times = new double[10];

            Console.Write("Enter the number of users in the competition: ");
            int nrSwimmers = int.Parse(Console.ReadLine());


            GetInfo(swimmerNames, times, ref nrSwimmers);

            int PositionFastest = GetFastest(times, nrSwimmers);
            double fastestTime = times[PositionFastest];

            Console.WriteLine("The winner is {0} finishing in {1} seconds.", swimmerNames[PositionFastest], fastestTime);

            
        }

        static void GetInfo(string[] swimmers, double[] times, ref int nrEl)
        {
            for(int i=0; i<nrEl;i++)
            {
                Console.Write("Enter swimmer name: ");
                swimmers[i] = Console.ReadLine();
                
                Console.Write("Enter swimmer's time: ");
                times[i] = double.Parse(Console.ReadLine());
            }
        }

        static int GetFastest(double[] times, int nrEl)
        {
            int fastest = 0;

            for(int i=1; i<nrEl; i++)
            {
                if(times[i] < times[fastest])
                {
                    fastest = i;
                }
            }
            
            return fastest;
        }
    }
}
