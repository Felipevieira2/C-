using System;
using System.Collections.Generic;
using System.Text;

namespace contaBancaria {
    class ContaCorrente {
        public string nome { get; set; }
        public int numContaCorrente { get; private set; }
        public double saldo { get; private set; }

        public ContaCorrente(string nome, int numContaCorrente) {
            this.nome = nome;
            this.numContaCorrente = numContaCorrente;
            this.saldo = saldo;
        }
        public void Sacar(double valorSaque) {

            this.saldo -= (valorSaque+5.00);
        }
        public void Depositar(double vlrDeposito) {

            this.saldo += vlrDeposito;
        }

        public override string ToString() {
            return "Titular: "
                  + nome
                  + " | Numero da conta: " 
                  + numContaCorrente
                  + " | Saldo: "
                  + saldo ;
        }
    }
}
