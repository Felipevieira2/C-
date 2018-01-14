using System;
using System.Globalization;
using System.Collections.Generic;
namespace CadastroFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {   

            Console.WriteLine("Quantos Clientes serão cadastrados? "); //Solicita a quantidade de Clientes 
            int qtdFuncionarios = int.Parse(Console.ReadLine()); //Le a quantidade de Cliente
            List<Funcionario> ListaFuncionarios = new List<Funcionario>();
            for (int i = 0; i < qtdFuncionarios; i++) { //laço para preencher os dados 
                Console.WriteLine("Digite o CPF do {0}º Funcionário: ", i+1);
                string cpf = Console.ReadLine();
                int posListaFuncionario = ListaFuncionarios.FindIndex(numCPF => numCPF.cpf == cpf); //percorre o indice da lista 
                if (posListaFuncionario == -1) { //verifica se o Funcionario foi digitado. se a posição é -1 significa que nada foi encontrado
                    Console.Write("Digite o Nome do {0}º Funcionário: ", i + 1);
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite o Salario do {0}º Cliente: ", i + 1);
                    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ListaFuncionarios.Add(new Funcionario(cpf, nome, salario)); //após os dados serem armazenados instancio o novo objeto na lista
                }
                else { // se a posição retornar diferente de -1, significa que o CPF foi encontrado e logo existe registro. 
                    Console.WriteLine("cpf já digitado!");
                    i--;//medida para não avançar a posição sem que a mesma seja preenchida. 
                }            
            }
            Console.WriteLine("Digite o número do CPF do Funcionários que receberá um aumento: ");
            string aumentoCPF = Console.ReadLine();
            for (int i = 0; i < qtdFuncionarios; i++) {
                    int funcionarioPos = ListaFuncionarios.FindIndex(numcpf => numcpf.cpf == aumentoCPF);  //retorna a posicao na lista do funcionario
                    if (funcionarioPos != -1) { //se for diferente de -1 significa que algo foi encontrado
                    Console.WriteLine("digite o percentual de aumento: ");
                    double aumentoPercentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ListaFuncionarios[funcionarioPos].AumentarSalario(aumentoPercentual);
                    Console.WriteLine("Salário atualizado com sucesso!!! Novo valor: " + ListaFuncionarios[funcionarioPos].salario);//atualizo o registro
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
