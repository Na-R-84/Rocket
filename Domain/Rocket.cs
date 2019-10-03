
namespace RocketSimulator.Domain
{
    abstract class Rocket
    {
        public string RocketName { get; }
        public double RocketWeight { get; set; }
        public double AmountOfFuel { get; set; }

        public Rocket(string rocketName, double rocketWeight, double amountOfFuel)
        {
            RocketName = rocketName;
            RocketWeight = rocketWeight;
            AmountOfFuel = amountOfFuel;
        }
        public abstract double EngineOn(double burnTime);
        public abstract double FuelLeft(double engineBurn, double remainingFuel);
        public abstract void Graph(double velocity, double time);
    }
}