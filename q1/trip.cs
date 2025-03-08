using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    internal class Trip
    {
        
        public string Destination;
        public int DistanceTraveled;
        public double TotalFuelCost;
        public double FuelConsumed;

        
        public Trip()
        {
            Console.WriteLine("Trip details are as follows:");
        }

        
        public void DisplayDetails()
        {
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Distance Traveled: {DistanceTraveled} miles");
            Console.WriteLine($"Total Fuel Cost: ${TotalFuelCost}");
            Console.WriteLine($"Fuel Consumed: {FuelConsumed} gallons");
        }

        
        public void CalculateMilesPerGallon()
        {
            if (FuelConsumed > 0)
            {
                double milesPerGallon = DistanceTraveled / FuelConsumed;
                Console.WriteLine($"Miles per Gallon: {milesPerGallon:F2}");
            }
            else
            {
                Console.WriteLine("Fuel consumed must be greater than zero to calculate MPG.");
            }
        }

        
        public void CalculateCostPerMile()
        {
            if (DistanceTraveled > 0)
            {
                double costPerMile = TotalFuelCost / DistanceTraveled;
                Console.WriteLine($"Cost per Mile: ${costPerMile:F2}");
            }
            else
            {
                Console.WriteLine("Distance traveled must be greater than zero to calculate cost per mile.");
            }
        }
    }

}
