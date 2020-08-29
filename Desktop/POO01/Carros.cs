using System;

namespace teste04
{
    public abstract class Carros
    
    {
        #region Properties

       public string Name { get; set; } // Nome
       public int Length { get; set; } // Comprimento
       public int Height { get; set; } // Altura
       public string Color { get; set; } // Cor
       public int Wheel { get; set; } // Rodas

       #endregion
       

         #region Behaviors
       
       public void RampUp(){

           Console.WriteLine("The car {Name} is Built.");
       }

       public void TurnOn(){
           
           Console.WriteLine("The car {Name} is started");
       }

       public void Sold(){

           Console.WriteLine("The car {Name} is Sold.");

           } 
       public void Drive(){

           Console.WriteLine("The car {Name} is Driven.");
       }
       
       #endregion
       
        }
    }
