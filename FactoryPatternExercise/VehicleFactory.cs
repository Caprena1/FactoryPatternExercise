using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class VehicleFactory
    {
        public IVehicle GetVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "motorcycle":
                    return new Motorcycle();
                case "suv":
                    return new SUV();
                case "car":
                    return new Car();
                default:
                    return new Car();
                    

            }

        }
    }

}



