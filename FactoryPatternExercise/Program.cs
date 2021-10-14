using System;

namespace FactoryPatternExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many tires are on your vehicle?");
            string userInput = Console.ReadLine();

            VehicleFactory factory = new VehicleFactory();
            IVehicle myVehicle = factory.GetVehicle(userInput);

            myVehicle.Drive();

            Console.WriteLine("Let's make another vehicle!");
            userInput = Console.ReadLine();
        }
    }
}
