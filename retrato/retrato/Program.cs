using System;

namespace retrato
{
    class Program
    {
        static void Main(string[] args)
        {
            bool teste = false;
            Console.WriteLine("digite a dimensão da foto, Exemplo: 10 10");
            string[] dimfoto = Console.ReadLine().Split(); //dimensão da foto
            Console.WriteLine("digite a dimensão do porta retrato, Exemplo: 10 10");
            string[] pRetrato = Console.ReadLine().Split(); //dimensão do porta retrato

            if (int.Parse(dimfoto[0]) <= int.Parse(pRetrato[0])) {
                if (int.Parse(dimfoto[1]) <= int.Parse(pRetrato[1])){
                    teste = true;
                }
                
            }
            if (int.Parse(dimfoto[1]) <= int.Parse(pRetrato[0])) {
                if (int.Parse(dimfoto[0]) <= int.Parse(pRetrato[1])) {
                    teste = true;
                }
            }
            if (teste == true) {
                Console.WriteLine("Teste OK!!!");
            }
            else {
                Console.WriteLine("Foto não cabe");
            }
            Console.ReadKey();
            

        }
    }
}
