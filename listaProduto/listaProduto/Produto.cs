using System;
using System.Globalization;
using System.Text;

namespace listaProduto {
    class Produto {
        public string descricao { get; set; }
        public double preco     { get;  set; }
        public int estoqueAtual { get; private set; }

        public Produto(string descricao, double preco) {
            this.descricao = descricao;
            this.preco = preco;
         
        }


        //vlrTotalEstoque = estoqueAtual* preco;
        public double CalcVlrTotal() {
            return estoqueAtual * preco;
        }
        public int RealizarEntradaProd(int qtd) {
            return estoqueAtual += qtd;
        }
        public int RealizarSaidaProd(int qtd) {
            return estoqueAtual -= qtd;
        }
        public override string ToString() {
            return descricao
                    + ", R$: "
                    + preco.ToString("F2", CultureInfo.InvariantCulture)
                    + ", "
                    + estoqueAtual
                    + " Unidades, Valor Total: "
                    + CalcVlrTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

