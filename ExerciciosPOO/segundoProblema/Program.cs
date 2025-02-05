using segundoProblema;
using System;
using System.Globalization;

Produto produto = new Produto();

Console.WriteLine("Entre com os dados do produto:");
Console.Write("Nome: ");
produto.Nome = Console.ReadLine();
Console.Write("Preco: ");
produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");

produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Dados do produto: " + produto);

Console.WriteLine();
Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
int quantidaAtualizada = int.Parse(Console.ReadLine());
produto.AdicionarProduto(quantidaAtualizada);
Console.WriteLine("Dados atualizados: " + produto);

Console.WriteLine();
Console.Write("Digite o número de produtos a ser removido do estoque: ");
quantidaAtualizada = int.Parse(Console.ReadLine());
produto.RemoverProduto(quantidaAtualizada);
Console.WriteLine("Dados atualizados: " + produto);






