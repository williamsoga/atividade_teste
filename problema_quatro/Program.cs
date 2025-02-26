decimal Preco;
string Produto;
decimal Dessconto = 0.15m;
decimal Desconto_Produto;

Console.WriteLine("insira um produto");
Produto=Console.ReadLine();

Console.WriteLine("insira  o valor  do produto ");
Preco=decimal.Parse(Console.ReadLine());

Desconto_Produto = Preco * Dessconto;
Console.WriteLine($"O produto {Produto} que custa {Preco} com desconto de 15% é : {Desconto_Produto}");

