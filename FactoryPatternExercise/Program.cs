using System;

namespace FactoryPatternExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many tires are on your vehicle?");
            var userInput = int.Parse(Console.ReadLine());
            var myVehicle = VehicleFactory.GetVehicle(userInput);
            VehicleFactory factory = new VehicleFactory();
            //IVehicle myVehicle = VehicleFactory.GetVehicle(int userInput);

            myVehicle.Drive();
            Console.WriteLine();
            Console.WriteLine("2 or 3 wheels: Motocycle");
            Console.WriteLine("4 wheels: SUV");
            Console.WriteLine("4 wheels: Car");
            Console.WriteLine();
            Console.WriteLine("Let's make another vehicle!");
            
        }
    }
}
