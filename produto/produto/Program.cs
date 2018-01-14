using System;
using System.Globalization;
namespace Cadproduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto;
            produto = new Produto();
            Console.WriteLine("Digite as informações do Produto: ");
            Console.Write("Digite a descrição ");
            produto.descricao = Console.ReadLine();
            Console.Write("Digite o preço: ");
            produto.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o estoque atual: ");
            produto.estoqueAtual = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados cadastrados!!!");
            Console.WriteLine(produto);
            Console.WriteLine("Digite a quantidade que deseja realizar a entrada: ");
            produto.RealizarEntradaProd(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados.");
            Console.WriteLine(produto);
            Console.WriteLine("Digite a quantidade que deseja realizar a saída: ");
            produto.RealizarSaidaProd(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados.");
            Console.WriteLine(produto);
            Console.ReadKey();

        }
    }
}
