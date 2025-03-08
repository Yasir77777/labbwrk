using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trip trip1 = new Trip();

            Console.Write("Enter Destination: ");
            trip1.Destination = Console.ReadLine();

            Console.Write("Enter Distance Traveled: ");
            trip1.DistanceTraveled = int.Parse(Console.ReadLine());

            Console.Write("Enter Total Gasoline Cost: ");
            trip1.TotalFuelCost = double.Parse(Console.ReadLine());

            Console.Write("Enter Gallons Consumed: ");
            trip1.FuelConsumed = double.Parse(Console.ReadLine());

            Console.WriteLine("\nTrip Details:");
            trip1.DisplayDetails();

            Console.WriteLine();
            trip1.CalculateMilesPerGallon();
            trip1.CalculateCostPerMile();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

}
    

