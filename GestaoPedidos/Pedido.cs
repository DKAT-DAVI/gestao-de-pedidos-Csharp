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

        // Calcula o preço total do pedido varrendo a lista de itens que foram calculados
        public Decimal CalcularTotal()
        {
            Decimal total = 0;

            foreach (Item item in Itens)
            {
                total += item.CalcularTotal();
            }

            return total;
        }
        
        public void AdicionarItem(Item item)
        {
        }

        //Contrutor
        public Pedido()
        {
            Itens = new List<Item>();
        }
        
        public Pedido(Int64 serial, Int64 notaFiscal, List<Item> itens)
        {
            Serial = serial;
            NotaFiscal = notaFiscal;
            Itens = itens;
        }


        // Override
        public override String ToString()
        {
            return $"{Serial}{NotaFiscal} : R$ {CalcularTotal().ToString("C")}";
        }
    }
}
