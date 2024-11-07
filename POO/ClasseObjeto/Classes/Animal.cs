using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ClasseObjeto.Classes
{
    public class Animal 
    {
        public string especie;

        public string cor; 

        public string nome; 

        public float idade; 

        public void FazerBarulho(string barulho)
        {
            
            Console.WriteLine($"Som do animal: {barulho}");
            
        }
        public void Envelhecer()
        {

            idade = idade + 1;

            
        }

    }
}