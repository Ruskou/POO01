using System;
using Dealership.Model;
using Dealership.Model.Base;

namespace Dealership
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Choose the car that you want:");
                string choosenCar = Console.ReadLine();
    
                Car car = null;
                if (choosenCar == "Audi A3")
                    car = new Audi();
    
                car.Name = "Audi A3";
                car.Length = 4;
                car.Height = 2;
                car.Color = "Black";
                car.RimSize = 17;
    
                car.RampUp();
                car.TurnOn();
                car.Sell();
                car.Drive();
                car.Accelerate();
            }
            catch(Exception)
            {
                Console.WriteLine("This model of car does not exist.");

                throw;
            }
        }
    }
}
