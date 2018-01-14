using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroFuncionario {
    class Funcionario {
        public string cpf { get; set; }
        public string nome { get; set; }
        public double salario { get; private set; }

        public Funcionario(string cpf, string nome, double salario) {
            this.cpf = cpf;
            this.nome = nome;
            this.salario = salario;
        }
        public override string ToString() {
            return "Nome: " 
                   + nome
                   + "\nCPF: "
                   + cpf 
                   + "\nSalário: "
                   + salario;
        }
        public double AumentarSalario(double aumento) {
            aumento = (aumento / 100) + 1;
            return salario = salario * aumento;
             
        }
      
    }
}
