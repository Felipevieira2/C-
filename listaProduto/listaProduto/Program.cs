using System;
using System.Collections.Generic;
using System.Globalization;
namespace listaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> carrinho = new List<Produto>();
            char cad = 's'; //reposta para cadastro
            
            while (cad == 's') {
                Console.Write("Dejesa cadastrar um novo produto? digite S ou N: ");
                cad = char.Parse(Console.ReadLine().ToLower());
                if (cad == 's') {
                    int i = 0;
                    Console.Write("digite a descrição do produto: ");
                    string descProduto = Console.ReadLine();
                    Console.Write("digite o preço do produto: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    carrinho.Add(new Produto(descProduto, preco));
                    Console.Write("digite a quantidade de estoque do produto: ");
                    int estoque = int.Parse(Console.ReadLine());
                    carrinho[i].RealizarEntradaProd(estoque);
                    i += 1;
                    
                }
            }
                    
            for (int i=0; i<carrinho.Count; i++) {
                Console.WriteLine(carrinho[i]);
            }
            Console.ReadKey();

        }
    }
}
