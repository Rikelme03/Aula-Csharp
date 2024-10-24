



//  Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// O número de pessoas que responderam SIM;
// O número de pessoas que responderam NÃO;
// O número de mulheres que responderam SIM;
// A porcentagem de homens que responderam NÃO entre todos os homens analisados

int qntmulher = 0;
int qnthomem = 0;
int qntGosta = 0;
int qntNaoGosta = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Voce poderia informar seu sexo !");
    string sexo = Console.ReadLine!();

    if ( sexo == "masculino")
    { 
        qnthomem++;
    }
    else   
    {
        qntmulher++;
    }
    
    Console.WriteLine("Você gostou do0 produto ! sim/nao ?");
    string resposta = Console.ReadLine!();
    Console.WriteLine(" ");
    Console.WriteLine("---------------------------------------");

    if (resposta == "sim")
    {
        qntGosta++;
    }
    else 
    {
        qntNaoGosta++;
    }
}

float percentualMulher  = (100 / qntmulher) * qntGosta;
float percentualHomem  = (100 / qnthomem) * qntNaoGosta;

Console.WriteLine($"Funcionarios que gostaram: {qntGosta}");
Console.WriteLine($"Funcionarios que nao gostaram : {qntNaoGosta}!");
Console.WriteLine($"Mulheres que responderam sim: {percentualMulher}");
Console.WriteLine($"Homens que falaram nao: {percentualHomem}");


