
int senha;
int senhaCorreta = 1234;

   Console.WriteLine("Digite a senha");
senha = int.Parse (Console.ReadLine());

if (senha == senhaCorreta)
{
    Console.WriteLine("ACESSO    PERMITIDO    caso    a    senha    seja    válida.");
}  else {
    Console.WriteLine("ACESSO    NEGADO    caso    a    senha    seja    inválida.");
}