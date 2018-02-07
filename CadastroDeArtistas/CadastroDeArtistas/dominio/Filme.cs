using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDeArtistas.dominio {
    class Filme {

        public int codFilme{ get; private set; }
        public string nomeFilme{ get; private set; }
        public string ano{ get; private set; }
        public List<Participacao> listaParticipa  {get; private set;}
        public Filme (int codFilme,string nomeFilme, string ano) {
            this.codFilme = codFilme;
            this.nomeFilme = nomeFilme;
            this.ano = ano;
            listaParticipa = new List<Participacao>();
        }
        public double CalcularTotal() {
            double soma = 0;
            for (int i = 0; i < listaParticipa.Count; i++) {
                soma = listaParticipa[i].CalcularCusto();
            }
            return soma;
        }
        public override string ToString() {
            string s = "Código do filme: "
                + codFilme + "\n"
                + " Nome: "
                + nomeFilme + "\n"
                + "Ano: "
                + ano + "\n"
                + "Participações: "; 
                for (int i = 0; i<listaParticipa.Count; i++) {
                   s = s+ listaParticipa[i]+ "\n";
                }

            s= s + " Valor total: " 
                + CalcularTotal();
            return s;
        }
    }
}
