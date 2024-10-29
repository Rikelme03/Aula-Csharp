
int[] num = new int[6];
int par = 0; int impar = 0;

for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine($"Informe o {i+1} numero: ");
    num[i] = int.Parse(Console.ReadLine());

    if (num[i] % 2 == 0)
    {
        par++;
    }else{
        impar++;
    }
}

Console.WriteLine(" ");

Console.WriteLine($"Numero par: {par} ");

for (int i = 0; i < num.Length; i++)
{
    if (num[i] % 2== 0)
    {
        Console.Write($"{num[i]} ");
        
    }
}


Console.WriteLine($"Numeros impar: {impar}");

for (int i = 0; i < num.Length; i++)
{
    if (num[i] % 2== 1)
    {
        Console.Write($"{num[i]} ");
    }
}
