using System;
using System.Collections.Generic;
using System.Text;

namespace aluguelQuartos
{
    class Quarto {
       public int numeroQuarto;
       public string nomePessoa;
       public string emailPessoa;
       public Quarto(string nomePessoa, int numeroQuarto) {
            this.numeroQuarto = numeroQuarto;
            this.nomePessoa = nomePessoa;

        }
       public Quarto(string nomePessoa, string emailPessoa, int numeroQuarto) {
            this.numeroQuarto = numeroQuarto;
            this.nomePessoa = nomePessoa;
            this.emailPessoa = emailPessoa;
        }
        public Quarto(string emailPessoa) {
            this.emailPessoa = emailPessoa;

       }

        public override string ToString() {
            return "Dados do 1° aluguel:"
                     + "\r\nNome: "
                     + nomePessoa
                        + "\r\nEmail: "
                        + emailPessoa
                        + "\r\nQuarto: " +
                        +numeroQuarto;   
        }
    }
}
