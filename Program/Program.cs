int qntmulher = 0;
int qnthomen = 0;
int qntGostaEsportes = 0;
int qntNaoGostaEsportes = 0;

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine("Digite 'f' para Feminino ou 'm' para Masculino:");
    string sexo = Console.ReadLine();

    if (sexo == "f")
    {
        qntmulher++;
    }
    else   
    {
        qnthomen++;
    }
    
    Console.WriteLine("Você gosta de esportes? Digite 's' para Sim ou 'n' para Não:");
    string gostaEsportes = Console.ReadLine();
    Console.WriteLine(" ");
    Console.WriteLine("-------------------------------------------------------------");

    if (gostaEsportes == "s")
    {
        qntGostaEsportes++;
    }
    else 
    {
        qntNaoGostaEsportes++;
    }
}

float percentual  = (100 / qnthomen + qntmulher) * qntGostaEsportes+ qntNaoGostaEsportes;

Console.WriteLine($"Total de Mulheres: {qntmulher}");
Console.WriteLine($"Total de Homens: {qnthomen}!");
Console.WriteLine($"Total de entrevistados: {qnthomen + qntmulher}");
Console.WriteLine($"Total que gostam de esportes: {qntGostaEsportes}");
Console.WriteLine($"Total que não gostam de esportes: {qntNaoGostaEsportes}");
Console.WriteLine($"Porcentagem de quem gosta de esporte: {percentual} %");
