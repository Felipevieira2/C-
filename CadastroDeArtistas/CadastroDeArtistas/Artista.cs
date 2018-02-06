using System;
using System.Collections.Generic;
using System.Globalization;

namespace CadastroDeArtistas
{
    class Artista : IComparable // para comparar os objs temos que definir uma subclasse
    {
        public int codArtista { get; private set; }
        public string nomeArtista { get; private set; }
        public double vlrCache { get; private set; }

        public Artista(int codArtista, string nomeArtista,double vlrCache)
        {
            this.codArtista = codArtista;
            this.nomeArtista = nomeArtista;
            this.vlrCache = vlrCache;
        }

        public override string ToString()
        {
            return "Código do Artista: " + codArtista + "| Nome: " + nomeArtista + " | Valor: " + vlrCache.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            Artista outro = (Artista)obj;
            int Resultado = nomeArtista.CompareTo(outro.nomeArtista);
            return -Resultado;
   
            
        }
    }
}
