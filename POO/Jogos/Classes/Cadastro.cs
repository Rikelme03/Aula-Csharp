using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogos.Classes
{
    public class Cadastro
    {
         public string nome { get; set; }

        public int lancamento { get; set; }
        public string genero { get; set; }

        public float preco { get; set; }


        public Cadastro(string no, int lan, string ge, float pre)
        {
            nome = no;
            lancamento = lan;
            genero = ge;
            preco = pre;

            Console.WriteLine($"O jogo foi Cadastrado");

        }
         public void ExibirDados()
        {
            Console.WriteLine(@$"
            Marca: {nome}
            Lançamento: {lancamento}
            Genero: {genero}
            Preço: {preco}
            ");
            
        }
    }
}