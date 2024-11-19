using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Clases.Aprendizagem
{
    public class Mago : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine($"O mago lanca seu feitico HaHaHa");
            
        }
    }
}