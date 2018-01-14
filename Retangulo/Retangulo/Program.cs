using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo;
            retangulo = new Retangulo();
            Console.Write("Digite a Altura: ");
            retangulo.altura = double.Parse(Console.ReadLine());
            Console.Write("Digite a Largura: ");
            retangulo.largura = double.Parse(Console.ReadLine());

            Console.WriteLine("A Área do retangulo é: ");

            Console.Write(retangulo.CalcularArea());
            Console.ReadKey();
        }
    }
}
