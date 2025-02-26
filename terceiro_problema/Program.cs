string nome;
int idade;

Console.WriteLine("insira o seu nome ");
nome=Console.ReadLine();

Console.WriteLine("insira  a sua idade");
idade=int.Parse(Console.ReadLine());

Console.WriteLine($"Olá {nome} , voce tem {idade} anos !");
