using System;

namespace aluguelQuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto dadosAluguel;
            string[] quarto;           
            Console.WriteLine("quantos alugueis serão registrados?");
            int numQuartos = int.Parse(Console.ReadLine()); //3
            quarto = new string[numQuartos]; 
              
            for (int i = 0; i<numQuartos; i++) {
                Console.WriteLine("Digite o nome do {0}º alguel: ");
                string nome  = Console.ReadLine();
                Console.WriteLine("Digite o email do {0}º alguel: ");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o número do quarto do {0}º alguel: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                dadosAluguel = new Quarto(nome, email, numeroQuarto);
                quarto[i] = dadosAluguel.ToString();
            }

            Console.WriteLine(quarto[0]);
            Console.ReadKey();
        }
    }
}
