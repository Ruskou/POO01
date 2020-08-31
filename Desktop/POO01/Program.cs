using System;

namespace Dealership
{
    class Program
    {
        static void Main(string[] args)
        {
            Audi audi = new Audi();
            audi.Name = "Audi A3";
            audi.Length = 4;
            audi.Height = 2;
            audi.Color = "Black";
            audi.RimSize = 17;

            audi.RampUp();
            audi.TurnOn();
            audi.Sell();
            audi.Drive();
            audi.MotorAudi();
            audi.Accelerate();
        }
    }
}
