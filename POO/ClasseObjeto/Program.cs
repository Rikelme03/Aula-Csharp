using ClasseObjeto.Classes;

Animal cachorro = new Animal ();
Animal peixe = new Animal ();

peixe.nome= "Pirarucu";
peixe.especie= "Aquatico";
peixe.cor= "Vermelho e cinza";
peixe.idade= 7;


cachorro.nome =  "Spike";
cachorro.especie = "Vira lata";
cachorro.cor = "Carramelo";
cachorro.idade = 5;


Console.WriteLine($"");
Console.WriteLine($"Nome do meu Dognho {cachorro.nome} ");
Console.WriteLine($"Raca do meu Dognho {cachorro.especie} ");
Console.WriteLine($"Cor do meu Dognho {cachorro.cor} ");
Console.WriteLine($"Idade do meu Dognho {cachorro.idade} ");
Console.WriteLine($"");
Console.WriteLine($"");

Console.WriteLine($"Nome do meu Peixe e {peixe.nome} ");
Console.WriteLine($"Raca do meu peixe e {peixe.especie} ");
Console.WriteLine($"Cor do meu peixe e {peixe.cor} ");
Console.WriteLine($"Idade do meu peixe e {peixe.idade} ");
Console.WriteLine($"");

Console.WriteLine(@"
*=================================*
|              Fim :)             |
*=================================*



");
