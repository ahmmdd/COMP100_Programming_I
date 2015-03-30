using System;
/*
 * Thomas’ Towing Services would like an application that calculates and display the cost of a towing job. The cost is based on the 
 * towing rate, the distance as well as a flat service rate. The service rate is the same regardless of the towing distance and it is 
 * always applied in any job.
 */
namespace Ass2Q10{
    class Program{
        static void Main(string[] args){
            //input towingRate, distance, serviceRate
            int towingRate, distance, serviceRate;
            Console.WriteLine("Enter towing rate: ");
            towingRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter distance: ");
            distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter serviceRate: ");
            serviceRate = Convert.ToInt32(Console.ReadLine());
            //output cost of towing
            int towingCost;
            towingCost = ((towingRate * distance) + serviceRate);
            Console.WriteLine("The total towing cost is {0:c}", towingCost);

            Console.ReadLine();
        }
    }
}
