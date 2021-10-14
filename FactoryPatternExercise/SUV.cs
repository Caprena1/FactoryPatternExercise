using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class SUV : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new Car!");
        }

    }
}
