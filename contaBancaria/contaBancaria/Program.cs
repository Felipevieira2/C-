using System;
using System.Globalization;
namespace contaBancaria {
    class Program {
        static void Main(string[] args) {
            int numContaCorrente;
            string nome, deposito , saque;
            double vlrDeposito, vlrSaque;
            ContaCorrente conta;
            Console.Write("Digite o titular da Conta: ");
            nome = Console.ReadLine();                
            Console.Write("digite o número da conta: ");
            numContaCorrente = int.Parse(Console.ReadLine());
            conta = new ContaCorrente(nome, numContaCorrente);
            Console.Write("deseja efetuar um deposito inicial? y/n: ");
            deposito = Console.ReadLine();         
            deposito = deposito.ToUpper();            
            switch (deposito) {
                case "Y":
                    Console.Write("digite o valor do primeiro deposito: ");
                    vlrDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.Depositar(vlrDeposito);
                    Console.WriteLine("Deposito de {0} efetuado, Saldo incial:{1} ", vlrDeposito,conta.saldo);
                    break;

                case "N":
                    break;

                default:
                    Console.WriteLine("Entrada inválida!");
                    break;

            }
            Console.WriteLine("Conta criada! ");
            Console.WriteLine(conta);
            Console.Write("deseja efetuar um novo deposito? y/n: ");
            deposito = Console.ReadLine();
            deposito = deposito.ToUpper();
            switch (deposito) {
                case "Y":
                    Console.Write("digite o valor do deposito: ");
                    vlrDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.Depositar(vlrDeposito);
                    Console.WriteLine("Deposito de " + vlrDeposito + "efetuado; Saldo atualizado: " + conta.saldo);
                    break;

                case "N":
                    break;

                default:
                    Console.WriteLine("Entrada inválida!");
                    break;

            }
            Console.WriteLine("deseja realizar um saque?  y/n:");
            saque = Console.ReadLine();
            saque = saque.ToUpper();
            switch (saque) {
                case "Y":
                    Console.Write("digite o valor do saque: ");
                    vlrSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.Sacar(vlrSaque);
                    Console.WriteLine("Saque de {0} efetuado com sucesso!", vlrSaque);
                    Console.WriteLine("Saldo atual: {0}", conta.saldo);
                    Console.WriteLine("Resumo da conta: ");
                    Console.WriteLine(conta);
                    break;

                case "N":
                    break;

                default:
                    Console.WriteLine("Entrada inválida!");
                    break;

            }
          

          
            Console.ReadKey();
        }
    }
}
