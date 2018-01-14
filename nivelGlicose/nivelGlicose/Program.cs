using System;
using System.Globalization;
namespace nivelGlicose {
    class Program {
        static void Main(string[] args) {
            double nGlicose;
            Console.WriteLine("Digite o seu nível de Glicose em mL");
            nGlicose = double.Parse(Console.ReadLine());
            if (nGlicose <= 100) {
                Console.WriteLine("Seu nível é normal");
            }
            if (nGlicose > 100 && nGlicose <= 140) {
                Console.WriteLine("Seu nível é elevado");
            }
            if (nGlicose > 140) {
                Console.WriteLine("Diabetes");
            }
            Console.WriteLine(nGlicose);
            Console.ReadKey();
        }
    }
}
