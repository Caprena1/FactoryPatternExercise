using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new Motorcycle!");
        }
    }
}
