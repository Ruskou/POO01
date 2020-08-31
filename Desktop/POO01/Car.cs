using System;

namespace Dealership
{
    public abstract class Car
    {
        #region Properties

       public string Name { get; set; } // Nome
       public int Length { get; set; } // Comprimento
       public int Height { get; set; } // Altura
       public string Color { get; set; } // Cor
       public int RimSize { get; set; } // Rodas
       protected int Velocity  { get; set; } // Velocidade

       #endregion
       

         #region Behaviors
       
       public void RampUp(){

           Console.WriteLine($"The car {Name} is Built.");
       }

       public void TurnOn(){
           
           Console.WriteLine($"The car {Name} is started");
       }

       public void Sell(){

           Console.WriteLine($"The car {Name} is Sold.");

           } 
       public void Drive(){

           Console.WriteLine($"The car {Name} is Driven.");
       }
       
       #endregion
       
        }
    }
