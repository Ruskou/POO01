using System;

namespace teste04
{
    public abstract class Car
    
    {
        #region Properties

       public string Name { get; set; } // Nome
       public int Length { get; set; } // Comprimento
       public int Height { get; set; } // Altura
       public string Color { get; set; } // Cor
       public int RimSize { get; set; } // Rodas


       #endregion
       

         #region Behaviors
       
       public void RampUp(){
           

           Console.WriteLine($"The {Name} car of {Color} color with {Length} meters long and {Height} meters high is built with {RimSize} wheels.");
       }

       public void TurnOn(){
           
           Console.WriteLine($"The {Name} car is started");
       }

       public void Sell(){

           Console.WriteLine($"The {Name} car is Sold.");

           } 
       public void Drive(){

           Console.WriteLine($"The {Name} car is Driven.");
       }

       public void Accelerate(){

           Console.WriteLine($"The {Name} car is accelerating.");
           
       } 
       
       #endregion
       
        }
    }
