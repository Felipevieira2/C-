using System;

namespace numerosInteiros {
    class Program {
        static void Main(string[] args) {
            int soma = 0;
            Console.WriteLine("Digite dois número inteiro");
            string[] numero = Console.ReadLine().Split();
            int n1 = int.Parse(numero[0]);
            int n2 = int.Parse(numero[1]);
            for (int i = n1; i < n2; i++) {
                if (i % 2 != 0) {
                    soma = soma + i;
                }

            }
            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}
