using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Clases.Aprendizagem
{
    public class Professor : Pessoa 
    {
        public int Nif { get; set; } 

        public float Salario { get; set; }

        public Professor(int _nif)
        {
            Nif = _nif;
        }
        
    }
}