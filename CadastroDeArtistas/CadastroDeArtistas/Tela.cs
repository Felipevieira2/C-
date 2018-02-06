using System;
using System.Collections.Generic;
using System.Globalization;

namespace CadastroDeArtistas
{
    class Tela
    {
       public static void MostrarTela()
        {
            Console.WriteLine("1 - Artistas ordenadamente");
            Console.WriteLine("2 - Cadastrar artista");
            Console.WriteLine("3 - Cadastrar filme");
            Console.WriteLine("4 - Mostrar dados de um filme");
            Console.WriteLine("5 - Sair ");
        }

        public static void ListarProduto()
        {
            for(int i = 0; i<Program.Artistas.Count; i++)
            {
                Console.WriteLine(Program.Artistas[i]);
            }
            Console.ReadLine();
        }

        public static void CadastrarProduto()
        {
            Console.Write("Digite o código do novo Artista: ");
            int codProduto = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o valor do Cachê");
            double preco = double.Parse(Console.ReadLine(Inva));
            Artista artista = new Artista(codProduto, nome, preco);
            Program.Artistas.Add(artista);
            Console.WriteLine("Cadastrado com sucesso!!!");
            Console.ReadLine();
        }
    }
}
