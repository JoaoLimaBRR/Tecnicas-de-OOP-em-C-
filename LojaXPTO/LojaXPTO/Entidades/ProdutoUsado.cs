using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaXPTO.Entidades
{
    class ProdutoUsado : Produto
    {
        public DateTime Fabricacao { get; set; }

        public ProdutoUsado()
        {

        }

        public ProdutoUsado(string nome, double preco, DateTime fabricacao) : base (nome, preco)
        {
            Fabricacao = fabricacao;
        }

        public override string Etiqueta()
        {
            return Nome
                + "( Used $)"
                + Preco
                + " (Data de fabricação: "
                + Fabricacao
                +")";
        }
    }
}
