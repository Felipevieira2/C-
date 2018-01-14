using System;
using System.Globalization; 
namespace fechamentoNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdAlunos;
            
            double media,n1,n2,n3;
            Console.WriteLine("Digite quantos alunos possuí a turma: ");
            qtdAlunos = int.Parse(Console.ReadLine());
           
            for(int i=0; i < qtdAlunos; i++) {
                Console.WriteLine("Digite as três notas do {0}º Aluno", i + 1);
                string[] notas = Console.ReadLine().Split(" ");
                n1 = double.Parse(notas[0],CultureInfo.InvariantCulture);
                n2 = double.Parse(notas[1],CultureInfo.InvariantCulture);
                n3 = double.Parse(notas[2],CultureInfo.InvariantCulture);
                media = (n1 + n2 + n3);
                Console.WriteLine("A nota do {0} º Aluno é {1}", i + 1 , media.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine(media);
            }
            Console.ReadKey();
            
        }
    }
}
