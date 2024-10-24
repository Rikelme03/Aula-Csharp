float  precoProduto = 200;
float minhaCarteira = 350;

if (minhaCarteira >= precoProduto)

 
{Console.WriteLine(@"
+-----------------------------------+
|         Compra concluida ;)       |
+-----------------------------------+
");
    
} else {
       Console.WriteLine(@"
+-----------------------------------+
|         Saldo insuficiente       |
+-----------------------------------+
");
}
