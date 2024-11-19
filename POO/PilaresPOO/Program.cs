using PilaresPOO.Clases.Pilares;

ContaCorrente ctRk = new ContaCorrente();
ctRk.Titular = "Rikelme Silva";
ctRk.Depositar(0000f);


Console.WriteLine($@" 

*---------------------*
|   Saldo da conta {ctRk.getSaldo()}  |
*---------------------*
");

float valorSacado = ctRk.Sacar(1500f);

Console.WriteLine($@" 
*--------------------------*
|   Valor do saque: {valorSacado}   |
*--------------------------*
");

Console.WriteLine($@" 
*--------------------------*
|    Novo Saldo: {ctRk.getSaldo()}     |
*--------------------------*
");





