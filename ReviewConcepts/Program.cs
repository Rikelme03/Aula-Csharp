// See https://aka.ms/new-console-template for more information
string nome;
string sobrenome;
double dataNascimento;
string email; 
string  telefone;
string  cpf;
string endereco;
string estdoCivil;



Console.WriteLine(@"
+-----------------------------------+
|           Seja Bem-vindo          |
-------------------------------------

");

Console.WriteLine("Ola, Digite seu nome:");
nome = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine($"{nome} qual seu sobrenome ?:");
sobrenome = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine($"Em que ano voce nasceu ?");
int anoNascimento = int.Parse(Console.ReadLine());
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;
Console.WriteLine("");

Console.WriteLine("Agora Digite seu EMAIL ?:");
email = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Agora Digite seu numero telefone ?:");
telefone = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Agora Digite seu CPF ?:");
cpf = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Agora Digite seu endereco ?:");
endereco = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Agora Digite seu Estado civil?:");
estdoCivil = Console.ReadLine();

Console.WriteLine(@"
+-----------------------------------+
|       Formulario concluido !      |
-------------------------------------

");




Console.WriteLine($"1) Seu nome e: {nome} {sobrenome}");
Console.WriteLine("");
Console.WriteLine($"2) Sua idade e: {idade}");
Console.WriteLine("");
Console.WriteLine($"3) Seu email e: {email}");
Console.WriteLine("");
Console.WriteLine($"4) Seu telefone e: {telefone}");
Console.WriteLine("");
Console.WriteLine($"5) Seu CPF e: {cpf}");
Console.WriteLine("");
Console.WriteLine($"6) Voce mora: {endereco}");
Console.WriteLine("");
Console.WriteLine($"7) Voce e: {estdoCivil}");
Console.WriteLine("");



     

