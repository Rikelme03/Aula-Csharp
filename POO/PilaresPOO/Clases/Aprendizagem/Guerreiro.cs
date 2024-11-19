using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Clases.Aprendizagem
{
    public class Guerreiro : Personagem 
    {
        
    public virtual void Atacar()   
        {
            Console.WriteLine($"Seu gurreiro esta em combate! 🤺");
            
        }

    }
}