using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaXPTO.Entidades
{
    class ProdutoImportado : Produto
    {
        public double CustoFrete { get; set; }

        public  ProdutoImportado()
        {

        }

        public ProdutoImportado(string nome, double preco, double custoFrete) : base (nome, preco)
        {
            CustoFrete = custoFrete;
        }

        public double PrecoTotal()
        {
            return Preco + CustoFrete;
        }

        public override string Etiqueta()
        {
            return Nome
                +" $"
                +PrecoTotal()
                +"(Custo do Frete: $ " 
                + CustoFrete
                + ")";
        }
    }
}
