using System;
using static System.Console;

namespace RocketSimulator.Domain
{
    class Starship : Rocket
    {

        public Starship(string rocketName, double rocketWeight, double amountOfFuel)
            : base(rocketName, rocketWeight, amountOfFuel)
        {
        }
        public override double EngineOn(double burnTime)
        {

            double nossleOutput = 4000 / (RocketWeight);
            double result = nossleOutput * Math.Log((AmountOfFuel + RocketWeight) /
                                ((AmountOfFuel + RocketWeight) - (3.85553d * burnTime)));

            return result;
        }
        public override double FuelLeft(double remainingFuel, double engineBurn)
        {
            return (remainingFuel + RocketWeight) - (3.85553d * engineBurn);
        }

        public override void Graph(double velocity, double time)
        {
            int timeIntervall = 0;
            for (int i = 0; i < time; i++)
            {

                timeIntervall = 5 * i++;
            }

            for (int i = 0; i < time; i++)
            {
                WriteLine($"{timeIntervall}");
            }

            Console.WriteLine(@"Simulation Graph : Simulation table
         km/s
          ^
          |
          4
          |
          |
          |
          |
          3 
          |
          |                                      
          |
          |
          2
          |
          |
          |
          |
          1
          |
          |
          |
          |
          0 -------------------------------------------------------------> Seconds
          0    5    10   15   20   25   30   35   40   45   50   55   60");

            ReadKey();
        }
    }
}