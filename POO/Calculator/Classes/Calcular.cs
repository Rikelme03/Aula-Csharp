using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Calcular
{
    public class Calcular
    {
        public float numero1 = 0;

        public float numero2 = 0 ;
        public void Somar(float valor)
        {
           valor = numero1 + numero2 ;
        }
        public void Subtracao (float valor)
        {
            valor = numero1 - numero2 ;
        }
        public void Divisao (float valor)
        {
            valor = numero1 / numero2 ;
        }
        public void Multiplicacao (float valor)
        {
            valor = numero1 * numero2;
        }
    }
}