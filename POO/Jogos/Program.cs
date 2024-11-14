string opcao;

using Classes.Cadastro;


do
{



Console.Write(@$"
    
    --------------------------
    |     Menu de opcoes 😁   |
    --------------------------
    |    1)Cadastrar Jogo      |
    |    2)Listar Jogos        |
    |    0)Sair                |
    --------------------------
    RESPOSTA:
    ");
 opcao = Console.ReadLine();

 if (opcao == 1)
{
    Console.Whire("Qual o Nome do Jogo ?");
    Cadastro.nome = (Console.ReadLine()!);

    Console.Whire("Qual a data de lançamento do lançamento ?");
    Cadastro.lancamento = (Console.ReadLine()!);

    Console.Whire("Qual o genero do jogo ?");
    Cadastro.genero = (Console.ReadLine()!);

    Console.Whire("Qual o preço do jogo ?");
    Cadastro.preco = (Console.ReadLine()!);
    jogos.Add(Cadastro);

    
} else if (opcao == 2)
{
    foreach (var item in jogos)  
    {  
        Console.WriteLine($"- " + {item});  
    }  
} else if (opcao == 3){

    Console.Write("Obrigado por utilizar nosso programa !")

} else {
    Console.WriteLine($"Opcao inavlida ! 😒");
}


} while (opcao == 3);