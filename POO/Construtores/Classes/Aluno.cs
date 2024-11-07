using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes;
    public class Aluno
    {
         public string Nome { get; set; }
        public string Curso { get; set; }
        public int Idade { get; set; }
        public float Cpf { get; set; }


    public Aluno(string no, string cu, int id, float cp){

        Nome = no;
        Curso = cu;
        Idade = id;
        Cpf = cp;

    }

    public void ExibirDados()
    {
        Console.WriteLine(@$"
        Nome do Aluno: {Nome}
        Nome do curso: {Curso}
        Idade do aluno: {Idade}
        CPF do aluno: {Cpf}
        ");
        Console.WriteLine(@"
        
        *-----------------------------*
        |  Finalizado com sucesso 👌 |
        *-----------------------------*
        
        ");
        
}
}