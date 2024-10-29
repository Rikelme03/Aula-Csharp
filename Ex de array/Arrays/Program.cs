string[] carro = new string[3];
string favorito;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Digite o nome do carro a ser cadastrado ! :");
    carro[i] = Console.ReadLine()!;

}

Console.WriteLine($" =======================================================");
Console.WriteLine($" |   O carro cadastradado e {carro[0]}, {carro[1]}, e {carro[2]}  |");
Console.WriteLine($" =======================================================");

Console.WriteLine("Qual carro e seu favorito :");
favorito = Console.ReadLine()!;

Console.WriteLine($"Carro Favorito 😍:" {favorito});