using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(int userInput)
        {
            switch (userInput)
            {
                case 2:
                case 3:
                    return new Motorcycle();
                case 4:
                    return new SUV();
                case  5:
                    return new Car();
                default:
                    return new Car();
                    

            }

        }
    }

}



