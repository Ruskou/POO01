using System;

namespace teste04 {
   
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