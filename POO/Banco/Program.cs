using Banco.Classes ;

Console.Clear();
Console.WriteLine($"Bem vindo ao Nubank");
Console.WriteLine();

ContaCorrente contaRikelme = new ContaCorrente ();
ContaCorrente contaBrian = new ContaCorrente ();


contaRikelme.Titulo = "Rikelme";
contaRikelme.Depositar(1000000);

contaBrian.Titulo = "Brian";
contaBrian.Depositar(1000000);
Console.WriteLine($"");
Console.WriteLine($"Conta do {contaRikelme} tem R$: {contaRikelme.Saldo}" );
Console.WriteLine($"");
Console.WriteLine($"Conta do {contaBrian} tem R$: {contaBrian.Saldo}" );
Console.WriteLine($"");
contaBrian.Sacar(250f);

Console.WriteLine($"");
Console.WriteLine($"Voce fez um deposito em sua conta e ficou com R$: {contaBrian.Saldo}");
Console.WriteLine($"");
Console.WriteLine($"Conta da {contaRikelme.Titulo} tem de saldo R$: {contaRikelme.Saldo}");
Console.WriteLine($"");
Console.WriteLine($"Conta da {contaBrian.Titulo} tem de saldo R$: {contaBrian.Saldo}");
Console.WriteLine($"");





