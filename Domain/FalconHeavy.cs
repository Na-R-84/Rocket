using System;
using static System.Console;

namespace RocketSimulator.Domain
{
    class FalconHeavy : Rocket
    {

        public FalconHeavy(string rocketName, double rocketWeight, double amountOfFuel)
            : base(rocketName,rocketWeight,amountOfFuel)
        {
        }

        public override double EngineOn(double burnTime)
        {
            double nossleOutput = 6000 / (RocketWeight);
            double result = nossleOutput * Math.Log((AmountOfFuel + RocketWeight) /
                                ((AmountOfFuel + RocketWeight) - (7.15553 * burnTime)));
            return result;

        }
        public override double FuelLeft(double remainingFuel, double engineburn)
        {
            return (remainingFuel + RocketWeight) - (7.15553d * engineburn);


        }

        public override void Graph(double velocity, double time)
        {

            Console.WriteLine(@"Simulation table
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