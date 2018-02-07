using System;
using System.Collections.Generic;
using System.Globalization;
using CadastroDeArtistas.dominio;
namespace CadastroDeArtistas {
    class Tela {
        public static void MostrarTela() {
            Console.WriteLine("1 - Artistas ordenadamente");
            Console.WriteLine("2 - Cadastrar artista");
            Console.WriteLine("3 - Cadastrar filme");
            Console.WriteLine("4 - Mostrar dados de um filme");
            Console.WriteLine("5 - Sair ");
        }

        public static void ListarProduto() {
            for (int i = 0; i < Program.Artistas.Count; i++) {
                Console.WriteLine(Program.Artistas[i]);
            }
            Console.ReadLine();
        }

        public static void CadastrarArtista() {
            Console.Write("Digite o código do novo Artista: ");
            int codProduto = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o valor do Cachê");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Artista artista = new Artista(codProduto, nome, preco);
            Program.Artistas.Add(artista);
            Console.WriteLine("Cadastrado com sucesso!!!");
            Console.ReadLine();
        }

        public static void CadastrarFilme() {
            Console.WriteLine("Cadastro de filme.");
            Console.Write("Código: ");
            int codFilme = int.Parse(Console.ReadLine());
            Console.Write("Digite o Título: ");
            string nomeFilme = Console.ReadLine();            
            Console.WriteLine("Digite o ano: ");
            string ano = Console.ReadLine();
            Filme filme = new Filme(codFilme, nomeFilme,ano);
            Program.filmes.Add(filme);
            Console.WriteLine("Quantas participações possuem o filme? ");
            int qtdParticipa = int.Parse(Console.ReadLine());
            for (int i = 0; i<qtdParticipa; i++) {
                Console.WriteLine("Digite o código do {0}º ator: ", i + 1);
                int codAtor = int.Parse(Console.ReadLine());
                int pos = Program.Artistas.FindIndex(x=>x.codArtista == codAtor);
                if (pos == -1) {
                    Console.WriteLine("Não encontrado...");
                    Console.WriteLine("Tente novamente...");
                    --i;
                }else {
                    Console.WriteLine("Desconto: ");
                    double desconto = double.Parse(Console.ReadLine());
                    Participacao listaParticipacao = new Participacao(desconto, filme, Program.Artistas[pos]);
                    filme.listaParticipa.Add(listaParticipacao);
                    
                }
                

            }

        }

        public static void MostrarFilme() {
            Console.WriteLine("CONSULTA DE FILME.");
            Console.Write("Digite o código: ");
            int codProduto = int.Parse(Console.ReadLine());
            int pos = Program.filmes.FindIndex(x => x.codFilme == codProduto);
            if (pos == -1) {
                Console.WriteLine("Código do filme não encontrado!!!");
            }
            else {
                Console.WriteLine(Program.filmes[pos]);
                Console.ReadKey();
            }
        }

    }
}
