using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPedidos
{
    internal class Pedido
    {
        //Propriedades
        public static Int64 Serial { get; set; }
        public Int64 NotaFiscal { get; set; }
        public List<Item> Itens { get; set; }

        //Métodos
        public Decimal CalcularTotal()
        {
            return 0;
        }
        public void AdicionarItem(Item item)
        {

        }
    }
}
