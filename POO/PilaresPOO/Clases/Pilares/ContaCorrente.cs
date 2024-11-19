using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Clases.Pilares
{
    public class ContaCorrente : Conta 
    {
        
       public float Limite;

        public bool Transferir(float valor, Conta contaDestino){

            return false;
        }

        public override bool Depositar (float valor)
        {
            
            
            if (valor >= 0)
            {
                Saldo = Saldo + valor;
                return true;
            } else {
                Console.WriteLine($"ERRO :(");
                return false;
                
            }
        }

        public override float Sacar (float valor)
        {

            

            if (valor >= Saldo)
            {
               Saldo = Saldo - valor ; 
                return valor;
            }   else {
                Console.WriteLine($"ERRO :(");

                return 0;
                
                
            }

        }


    }
}