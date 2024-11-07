using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Calcular

{
    public class Calcular
    {
        public float numero1 = 0,numero2 = 0 ;

        public void Somar()
        {
           float resultado = numero1 + numero2 ;
           Console.WriteLine($" O resultado da conta e: {resultado}");
        }
        public void Subtracao ()
        {
            float resultado = numero1 - numero2 ;
            Console.WriteLine($"    O resultado da conta e: {resultado}");
        }
        public void Divisao ()
        {
            float resultado = numero1 / numero2 ;
            Console.WriteLine($"    O resultado da conta e: {resultado}");
        }
        public void Multiplicacao ()
        {
            float resultado = numero1 * numero2;
            Console.WriteLine($"    O resultado da conta e: {resultado}");
        }   
    } 
} 