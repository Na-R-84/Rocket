using System;
using static System.Console;
using RocketSimulator.Domain;

namespace Rocket_Simulator
{
    class Program
    {
        static Rocket[] rocketList = new Rocket[5];
        static void Main(string[] args)
        {
            bool isRunning = true;
            int i = 0;

            while (isRunning)
            {
                Clear();
                Console.ForegroundColor
              = ConsoleColor.Magenta;
                WriteLine(" -- Menu -- ");

                WriteLine("1. Add rocket");
                WriteLine("2. List rocket");
                WriteLine("3. Run simulation");
                WriteLine("4. Run Simulation with graph");
                WriteLine("5. Exit");

                ConsoleKeyInfo pressedKey = ReadKey();

                switch (pressedKey.Key)
                {
                    case ConsoleKey.D1:
                        Clear();
                        WriteLine("--Add your Rocket--");
                        WriteLine();
                        WriteLine("[1] Starship, SpaceX\n[2] Falcon Heavy, SpaceX");

                        ConsoleKeyInfo rocketChoice = ReadKey();

                        switch (rocketChoice.Key)
                        {
                            case ConsoleKey.D1:
                                rocketList[i] = new Starship("Falcon 9, SpaceX", 549, 1600);

                                break;
                            case ConsoleKey.D2:
                                rocketList[i] = new FalconHeavy("Falcon Heavy, SpaceX", 1420, 3000);

                                break;
                        }
                        i++;

                        break;

                    case ConsoleKey.D2:
                        Clear();

                        int counter = 1;
                        WriteLine("Simulated Rockets");
                        WriteLine("----------------------------------------------------------------------");
                        foreach (Rocket eachRocketShip in rocketList)
                        {
                            if (rocketList[counter - 1] == null) continue;
                            WriteLine($"{counter++}. {eachRocketShip.RocketName}");
                        }

                        WriteLine("\n\nPress any key to continue...");
                        ReadLine();

                        break;

                    case ConsoleKey.D3:
                        Clear();

                        WriteLine("Engine burn period (sec):");
                        double engineBurn = double.Parse(ReadLine());

                        Clear();
                        WriteLine("Engine burn period (sec):");
                        WriteLine("\n Rocket\t\t\t\t\t Velocity (km/s)\t\t\t Fuel left (tons)");
                        WriteLine("--------------------------------------------------------------------------------------");


                        foreach (var rocket in rocketList)
                        {
                            if (rocket == null) continue;

                            WriteLine($"{rocket.RocketName}\t\t\t{Math.Round(rocket.EngineOn(engineBurn), 2)}\t\t\t\t{Math.Round(rocket.FuelLeft(rocket.AmountOfFuel, engineBurn), 1)} ");
                        }

                        ReadLine();
                        break;

                    case ConsoleKey.D4:

                        foreach (var rocket in rocketList)
                        {
                            if (rocket == null) continue;

                            WriteLine("Engine burn period (sec):");
                            double engineBurn1 = double.Parse(ReadLine());

                            rocket.Graph(rocket.EngineOn(engineBurn1), engineBurn1);
                        }
                        ReadKey();

                        break;

                    case ConsoleKey.D5:

                        isRunning = false;
                        break;
                }
            }
        }
    }
}