using System;
using Dealership.Model.Base;

namespace Dealership.Model 
{
    public class Audi : Car
    {
        public override void Accelerate()
        {
            Velocity = 10;

            Console.WriteLine($"The car is accelerating at {Velocity} km/h.");
        }

        public void MotorAudi()
        {
            Console.WriteLine("Audi exclusive engine.");
        }
    }
}