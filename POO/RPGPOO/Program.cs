using RPGPOO.Personagens;

Personagens Personagem = new Personagens ();
Personagem.Nome = "";
Personagem.Idade = 0;
Personagem.Ia = " ";
Personagem.Armadura = " ";


Console.WriteLine($"");
Console.Write($"Defina o nome do personagem: ");
Personagem.Nome = (Console.ReadLine()!);
Console.Write($"Defina a idade do seu personagem: ");
Personagem.Idade = int.Parse(Console.ReadLine()!);
Console.Write($"Defina a IA do seu personagem: ");
Personagem.Ia = (Console.ReadLine()!);
Console.Write($"Defina a Armadura do seu personagem: ");
Personagem.Armadura = (Console.ReadLine()!);

Console.WriteLine($"");

string opcao = "";

Console.Write(@"
+===================+
| Escolha uma opcao |
+===================+

1)Atacar 😈
2)Defender 🫤
3)Recuperar a armadura 🥵
R: ");

opcao = (Console.ReadLine()!);


if (opcao == "1")
{
    Personagem.Atacar();
} else if (opcao == "2")
{
    Personagem.Defender();
} else if (opcao == "3")
{
    Personagem.RestaurarArmadura();
} else {
    Console.WriteLine($"Opcao Invalida :(");
    
}








// Nome: Define o nome do personagem.                
// Idade: Representa a idade do personagem.
               
// Armadura: Informa o nome da armadura utilizada pelo personagem.
               
// IA: Nome da inteligência artificial que auxilia o personagem.