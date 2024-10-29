float salario;
float total;


Console.WriteLine("Ola, Digite seu salario:");
salario = float.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Gastos  mensais !");
total = float.Parse(Console.ReadLine());
Console.WriteLine("");

if (salario >= total)
    {Console.WriteLine(@"
+-----------------------------------+
|    Parabens junte seu DIN DIN ;   |
+-----------------------------------+
");
} else {
    Console.WriteLine(@"
+-----------------------------------+
|    Vishhhh vai ficar devendo :(    |
+-----------------------------------+
");
}
