using System;
using Dealership.Model.Base;

namespace Dealership.Model 
{
    public class Audi : Car
    {
        public void MotorAudi()
        {
            Console.WriteLine("Audi exclusive engine.");
        }

        public void Accelerate()
        {
            Velocity = 10;

            Console.WriteLine($"The car is Accelerating {Velocity}.");
        }
    }
}