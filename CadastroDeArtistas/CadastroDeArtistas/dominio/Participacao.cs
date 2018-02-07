using System;
using System.Collections.Generic;
using System.Text;
using CadastroDeArtistas.dominio;
namespace CadastroDeArtistas.dominio {
    class Participacao {
        public double desconto{ get; private set; }
        public Filme filme { get; private set; }
        public Artista artista { get; private set; }

        public Participacao (double desconto, Filme filme,Artista artista) {
            this.desconto = desconto;
            this.artista = artista;
            this.filme = filme;
        }
        public double CalcularCusto() {
            double custo =  artista.vlrCache - desconto;
            return custo;
             
        }
        public override string ToString() {
            return "Artista: "
                + artista.nomeArtista
                + " Cachê: "
                + artista.vlrCache
                + " Desconto: "
                + desconto
                + " custo total: " 
                + CalcularCusto();
        }
    }
}
