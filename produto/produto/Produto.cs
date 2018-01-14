using System;
using System.Globalization;

namespace Cadproduto {
    class Produto {
        public string descricao;
        public double preco;
        public int estoqueAtual;

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
