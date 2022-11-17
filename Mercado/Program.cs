using Mercado;

Cliente cliente = new Cliente();
cliente.Nome = "André";
cliente.Cpf = "111.444.666-88";
cliente.Email = "andre@email.com";
cliente.Idade = 23;



Console.WriteLine(cliente.Nome);
Console.WriteLine(cliente.Cpf);
Console.WriteLine(cliente.Idade);

//Exibe tudo
Console.WriteLine(cliente.ToString());
//OU
Console.WriteLine(cliente);
