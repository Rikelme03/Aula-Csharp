using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes;
    public class Jogo
    {
        public string Nome { get; set; }
        public string Classificacao { get; set; }
        public int Idade { get; set; }
        public float Valor { get; set; }


    public Jogo(string nome, string classificacao, int idade, float valor){

        Nome = nome;
        Classificacao = classificacao;
        Idade = idade;
        Valor = valor;

    }

    public void ExibirDados()
    {
        Console.WriteLine(@$"
        Nome do jogo: {Nome}
        Jode de: {Classificacao}
        Idade minima para jogar: {Idade}
        Valor do jogo: {Valor}
        ");
        Console.WriteLine(@"
        
        *-----------------------------*
        |  Finalizado com sucesso 👌 |
        *-----------------------------*
        
        ");
}

 }