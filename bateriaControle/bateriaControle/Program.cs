using System;

namespace bateriaControle {
    class Program {
        static void Main(string[] args) {
            double totalBateria;
            int qtdVezesJogadas;
            double[] horasJogadas;
            Console.WriteLine("Digite a quantidade de horas total da bateria: ");
            totalBateria = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de vezes que irá jogar");
            qtdVezesJogadas = int.Parse(Console.ReadLine());
            horasJogadas = new double[qtdVezesJogadas];
            for (int i = 0; i < qtdVezesJogadas; i++) { //menor que qtdvezesjogada para não 
                                                        //exceder o tamanho do array

                Console.WriteLine("Digite por favor a quatidade de horas da {0}º vez ", i + 1);
                horasJogadas[i] = double.Parse(Console.ReadLine());
                totalBateria -= horasJogadas[i];
                if (totalBateria > 0) {
                    Console.WriteLine("Você ainda possuí {0} de batéria", totalBateria);
                }
                else {
                    Console.WriteLine("Recarregar!!!!");
                }


            }

            Console.ReadLine();
        }
    }
}
