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
        
        private string _nome;
        public String Nome 
        { 
            get
            {
                return _nome;
            } 

            // Se o _nome for maior que 32 caracteres o _nome vai receber somente os 32 primeiros caracteres
            set
            {
                if (value.Length > 32)
                {
                    _nome = value.Substring(0, 32);
                }

                else
                {
                    _nome = value;
                }
            }
        }


        public Decimal Preco { get; set; }

        //Contrutores
        public Produto() {}

        public Produto(Int64 codigo, String nome, Decimal preco)
        {
            Codigo = codigo; 
            Nome = nome; 
            Preco = preco; 
        }

        // ToString
        public override string ToString() 
        {
            return $"{Nome} [R${Preco}]";
        }
    }
}
