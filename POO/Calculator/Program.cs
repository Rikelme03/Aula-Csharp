using System.Data.Common;
using Calculator;

Calculando resultado = new Calculando;

Console.WriteLine(@"
╔═══════════════╗
   Bem - Vindo
╚═══════════════╝");

Console.WriteLine($"Digite o primeiro numero! :");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine($"");

Console.WriteLine($"Digite o primeiro numero! :");
float n2 = float.Parse(Console.ReadLine());
Console.WriteLine($"");

Console.WriteLine(@"
╔═══════════════╗
   Bem - Vindo
╚═══════════════╝");


Console.WriteLine(
    @"Esolha uma opcao abaixo ! 
    1) Somar 
    2) Subtrair
    3) Divisao
    4) Multiplicacao");

string Opcao = (Console.ReadLine());

if (Opcao == "1")
{
    Console.WriteLine($"Resultado da soma{Somar}");
    
} 

else if (Opcao == "2"){
    Console.WriteLine($"Resultado da Subtracao{Subtracao}");
} 

 else if (Opcao == "3"){
    Console.WriteLine($"Resultado da Divisao{Divisao}");
}  

else {
    Console.WriteLine($"Resultado da Multiplicacao{Multiplicacao}");
}  
