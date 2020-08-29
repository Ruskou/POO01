using System;

namespace teste04
{
    class Program
    {
        static void Main(string[] args)
        {
            Audi audi = new Audi();
            audi.Name = "Audi A3";
            audi.Length = 4000;
            audi.Height = 180;
            audi.Color = "Preto";
            audi.Wheel = 17;

            audi.RampUp();
            audi.TurnOn();
            audi.Sold();
            audi.Drive();
            audi.MotorAudi();
            
            
        }
    }
}
