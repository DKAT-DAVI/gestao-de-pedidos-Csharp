using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPedidos
{
    internal class Item
    {
        //Propriedades
        public Int16 Quantidade { get; set; }
        public Produto Produto { get; set; }

        //Calcula o total dos itens
        public Decimal CalcularTotal()
        {
            return Quantidade * Produto.Preco;
        }

        //Construtores
        public Item()
        {
        }

        public Item(Int16 quantidade, Produto produto)
        {
            Quantidade = quantidade;
            Produto = produto;
        }

        //ToString
        public override string ToString()
        {
            return $"{Quantidade} x {Produto} = {CalcularTotal()}";
        }
    }
}
