using System;
using System.Collections.Generic;
using CadastroDeArtistas.dominio;
namespace CadastroDeArtistas
{
    class Program
    { 
        public static List<Artista> Artistas = new List<Artista>();
        public static List<Filme> filmes = new List<Filme>();
        static void Main(string[] args)
        {
            
            Artistas.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
            Artistas.Add(new Artista(102, "Chris Evans", 2500000.00));
            Artistas.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            Artistas.Add(new Artista(104, "Morgan Freeman", 4000000.00));
            Artistas.Sort();
            int opcao = 0;
            while (opcao != 5)
            {
                Console.Clear();
                Tela.MostrarTela();
                Console.WriteLine("Escolha uma opção!!!");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Tela.ListarProduto();
                        break;
                    case 2:
                        Tela.CadastrarArtista();
                        Console.ReadKey();
                        break;
                    case 3:
                        Tela.CadastrarFilme();
                        break;
                    case 4:
                        Tela.MostrarFilme();
                        break;                       
                    case 8:
                        for (int i = 0; i < filmes.Count; i++) {
                            Console.WriteLine(filmes[i]);
                            
                        }
                        Console.ReadKey();
                        break;


                }

            }
          
        }
    }
}
