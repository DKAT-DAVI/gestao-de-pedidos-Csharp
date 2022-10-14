using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPedidos
{
    internal class Item
    {
        public Int16 Quantidade { get; set; }
        public Produto Produto { get; set; }

        public Decimal CalcularTotal()
        {
            return Quantidade * Produto.Preco;
        }

        public Item()
        {

        }

        public Item(Int16 quantidade, Produto produto)
        {
            Quantidade = quantidade;
            Produto = produto;
        }

        public override string ToString()
        {
            return $"{Quantidade} x {Produto} = {CalcularTotal()}";
        }
    }
}
