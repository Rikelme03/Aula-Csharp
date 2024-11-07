using  Construtores.Classes;

// Console.WriteLine(@"
// ⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
// ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡀⠀   ⣠⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀
// ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡞⠉⠙⢳⣄⢀⡾⠁⠈⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀
// ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⡄⠀⠀⠙⢿⡇⠀⢰⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀
// ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣦⡀⠀⠀⠹⣦⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
// ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢳⣄⠀⠀⠈⠻⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀
// ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡞⠋⠛⢧⡀⠀⠀⠘⢷⡀⠀⠀⠀⠀⠀⠀⠀
// ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡴⠾⣧⡀⠀⠀⠹⣦⠀⠀⠈⢿⡄⠀⠀⠀⠀⠀⠀
// ⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣿⠀⠀⠈⠻⣄⠀⠀⠀⠀⠀⠀⠈⣷⠀⠀⠀⠀⠀⠀
// ⠀⠀⠀⠀⠀⠀⠀⢠⡟⠉⠛⢷⣄⠀⠀⠈⠀⠀⠀⠀⠀⠀⣰⠏⠀⠀⠀⠀⠀⠀
// ⠀⠀⠀
// ⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣦⡀⠀⠀⠀⠀⠀⠀⢀⣠⠞⠁⠀⠀⠀⠀⠀⠀⠀⠀
// ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠶⣤⣤⣤⡤⠶⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
// ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");


// Veiculo carro1 = new Veiculo ("Ford","Mustang",2023,"Preto");
// Jogo jogo1 = new Jogo ("call of dut","Tiro",12, 199.99f);
// Jogo jogo2 = new Jogo ("Minecraft","Criatividade",3, 13.99f);
// Jogo jogo3 = new Jogo ("Krunker","Tiro",18, 0.00f);
// Jogo jogo4 = new Jogo ("GTA IV","Tiro e luta",18, 59.99f);

// Aluno aluno1 = new Aluno ("Rikelme silva","Desenvolvimento de sistemas",16,475.400f);


// List<Jogo> estoqueJogos = new List<Jogo> ();

// estoqueJogos.Add(jogo1);
// estoqueJogos.Add(jogo2);
// estoqueJogos.Add(jogo3);
// estoqueJogos.Add(jogo4);

// carro1.ExibirDados();
// jogo1.ExibirDados(); 
// aluno1.ExibirDados(); 

// foreach (var Jogo in estoqueJogos)
// {
//     Console.WriteLine($"Jogo: {Jogo.Nome}");  
// }

Jogo opcao = new Jogo;

do
{

Console.Write(@$"
    
    *--------------------------*
    |     Menu de opcoes 😁   |
    *--------------------------*
    |    1)Cadastrar Jogo      |
    |    2)Listar Jogos        |
    |    0)Sair                |
    *--------------------------*
    RESPOSTA:
    ");
 opcao = Console.ReadLine();

 if (opcao == "1")
{  

    

    
} else if (opcao == "2")
{
    


} else if (opcao == "3"){



} else {
    Console.WriteLine($"Opcao inavlida ! 😒");
}


} while (opcao == "0");




