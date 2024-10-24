//  DesafioLaco02: Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
// Total de Homens;
// Total de Mulheres;
// Média de idade dos Homens;
// Média de idade das mulheres.

int homem= 0;
int mulher=0;
int idade =0;

Console.WriteLine(@"
+-----------------------------------+
|           Bem-vindo ao            |
|            pesquisa de            |
|              Mercado              |
+-----------------------------------+
");

Console.WriteLine("");
Console.WriteLine("");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Voce poderia informar seu sexo ! m/f");
    string sexo = Console.ReadLine();

    Console.WriteLine("Qual seu peso ! :");
    float peso = float.Parse(Console.ReadLine());

    Console.WriteLine("Qual sua idade ! :");
    idade = int.Parse (Console.ReadLine());


    if ( sexo == "m")
    {
        homem++;
    }
    else   
    {
        mulher++;
    }
}



int mediaHomem = (idade / 10 ) * homem;
int mediaMulher = (idade / 10 ) * mulher;

 Console.WriteLine($"Total de Homens : {homem}");
 Console.WriteLine($"Total de Mulheres : {mulher}");
 Console.WriteLine($"Media das idades de mulheres : {mediaMulher}");
 Console.WriteLine($"Media das idades de homens  : {mediaHomem}");
