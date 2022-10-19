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

        // Métodos

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
        
        // Adiciona um item nos Itens
        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }


        //Contrutor
        static Pedido()
        {
            // Pega os dois últimos digitos do ano atual * 100000
            Serial = Convert.ToInt64(DateTime.Now.Year.ToString().Substring(2)) * 100000;
        }

        public Pedido()
        {
            Itens = new List<Item>();
            
            // Atribui o Serail a NotaFiscal 
            NotaFiscal = Serial;

            // Para cada vez que o contrutor é chamado, acrescenta-se 1 ao Serial 
            Serial += 1;
        }
        

        // ToString
        public override String ToString()
        {

            return $"{NotaFiscal} : R$ {CalcularTotal()}";
        }
    }
}
