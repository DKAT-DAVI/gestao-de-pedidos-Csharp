using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPedidos
{
    internal class Produto
    {
        //Propriedades
        public Int64 Codigo { get; set; }
        public String Nome { get; set; }
        public Decimal Preco { get; set; }

        //Contrutores
        public Produto() {}

        public Produto(Int64 codigo, String nome, Decimal preco)
        {
            Codigo = codigo; 
            Nome = nome; 
            Preco = preco; 
        }

        //ToString
        public override string ToString() 
        {
            return $"{Nome} [R${Preco}]";
        }
    }
}
