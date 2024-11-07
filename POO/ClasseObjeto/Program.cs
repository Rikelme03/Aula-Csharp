using ClasseObjeto.Classes;

Animal cachorro = new Animal ();
Animal peixe = new Animal ();

peixe.nome= "Carpa";
// peixe.especie= "Aquatico";
// peixe.cor= "Dourada";
peixe.idade= 2.1f;


cachorro.nome =  "Lupi";
// cachorro.especie = "Doberman";
// cachorro.cor = "Preto";
cachorro.idade = 4.5f;


// Console.WriteLine($"");
// Console.WriteLine($"Nome do meu Doguinho {cachorro.nome} ");
// Console.WriteLine($"Raca do meu Doguinho {cachorro.especie} ");
// Console.WriteLine($"Cor do meu Doguinho {cachorro.cor} ");
// Console.WriteLine($"Idade do meu Doguinho {cachorro.idade} ");
// Console.WriteLine($"");
// Console.WriteLine($"");

// Console.WriteLine($"Nome do meu Peixe e {peixe.nome} ");
// Console.WriteLine($"Raca do meu peixe e {peixe.especie} ");
// Console.WriteLine($"Cor do meu peixe e {peixe.cor} ");
// Console.WriteLine($"Idade do meu peixe e {peixe.idade} ");
// Console.WriteLine($"");

Console.WriteLine(@"
⠀⠀⠀⠀⠀⣠⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣦⡄⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀⠀⠀
⠀⣠⣴⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀
⠠⣿⣿⣿⣿⣿⠿⠛⠉⠀⠀⠀⠀⠈⠙⣿⣿⣿⣿⣿⣿⣿⣿⡆⠀⠀⠀
⠀⢻⣿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀
⠀⢠⡟⡠⠔⡦⠘⣫⣤⣄⠀⠀⠀⠀⠀⠀⠹⣿⣿⣿⣿⢟⠭⢽⡀⠀⠀
⠀⠈⢇⣴⡿⢧⡌⠙⠛⠻⠿⠿⢷⣦⠄⠀⠀⢸⣿⡿⠋⢂⠀⢀⠇⠀⠀
⠀⢠⣾⡿⠡⢄⡄⢠⠀⡴⠶⠶⠲⠷⠀⠀⠀⠈⠙⠁⠀⡆⠈⢸⡇⠀⠀
⠀⠀⢏⣴⠞⢛⣷⠀⠀⠑⠒⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠔⠉⡇⠀⠀
⠀⠀⠀⠟⠈⠜⡇⠀⠀⡀⡠⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢠⡌⠀⠀⠀
⠀⠀⢸⠀⡈⢰⡀⢀⠤⠤⠆⠀⠑⢄⠀⢠⠀⠀⠀⠀⠀⠀⢸⠃⠀⠀⠀
⠀⠀⠘⡀⠑⠈⢁⡠⢤⣀⣶⣶⢦⣄⣤⠘⡄⠀⠀⠀⠀⢘⣿⠀⠀⠀⠀
⠀⠀⠀⠐⡜⢄⣿⣞⣉⣡⣷⣿⣾⡟⢛⠸⠀⠀⠀⠀⠀⢈⡇⠀⠀⠀⠀
⠀⠀⠀⠀⠈⢂⢻⢝⠿⠍⢓⡉⠔⠁⣸⠇⠀⠀⠀⠀⠀⡜⠇⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠡⣧⠀⠀⠀⠀⠀⠔⠝⠀⠀⠀⠀⢀⠊⠀⠰⡀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⡇⠀⠀⠀⠀⠀⡰⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⠄⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠈⣢⢄⠠⠔⠊⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⡌⠢⡀

");

cachorro.FazerBarulho("Au Au Au");
Console.WriteLine($"Idade de {cachorro.nome} e {cachorro.idade}");
cachorro.Envelhecer();
Console.WriteLine($"");
peixe.FazerBarulho("Blu Blu Blu");
Console.WriteLine($"Idade da {peixe.nome} e {peixe.idade}");



