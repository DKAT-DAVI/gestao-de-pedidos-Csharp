using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPedidos
{
    internal class BancoDadosSimulado
    {
        //Propriedades
        public static BindingList<Pedido> Pedidos;
        public static List<Produto> Produtos;

        //Contrutores
        public BancoDadosSimulado()
        {
            Pedidos = new BindingList<Pedido>();
            Produtos = new List<Produto>();

            //Lista de Produtos
            //Cria objetos do tipo Produto e adiciona eles na lista de produtos do BancoDadosSimulado
            Produto p1 = new Produto(111, "Abacaxi", 12.20m);
            Produto p2 = new Produto(222, "Batata-Palha", 7.00m);
            Produto p3 = new Produto(333, "Cheiro-Verde", 2.00m);
            Produto p4 = new Produto(444, "Desinfetante", 6.00m);
            Produto p5 = new Produto(555, "Esfregão", 18.00m);
            Produto p6 = new Produto(666, "Farinha", 8.00m);
            Produto p7 = new Produto(777, "Gengibre", 15.50m);
            Produto p8 = new Produto(888, "Hortelã", 2.50m);
            Produto p9 = new Produto(999, "Iogurte", 4.50m);
            Produto p10 = new Produto(1010, "Jambo", 5.50m);

            //Adicionando lista de produtos ao BancoDadosSimulado
            BancoDadosSimulado.Produtos.Add(p1);
            BancoDadosSimulado.Produtos.Add(p2);
            BancoDadosSimulado.Produtos.Add(p3);
            BancoDadosSimulado.Produtos.Add(p4);
            BancoDadosSimulado.Produtos.Add(p5);
            BancoDadosSimulado.Produtos.Add(p6);
            BancoDadosSimulado.Produtos.Add(p7);
            BancoDadosSimulado.Produtos.Add(p8);
            BancoDadosSimulado.Produtos.Add(p9);
            BancoDadosSimulado.Produtos.Add(p10);
        }

        //Métodos
        public static List<Produto> LocalizarProdutoPorCodigo(Int64 codigo)
        {
            //Cria uma lista pra receber o produto buscado
            List<Produto> lista = new List<Produto>();

            //Varre a lista de produtos buscando o código digitado
            foreach (Produto produto in Produtos)
            {
                //Buscar dentro do código
                //if (Convert.ToString(produto.Codigo).Contains(Convert.ToString(codigo)))
                //{
                //    lista.Add(produto);
                //}

                //Verifica se o código passado como parâmetro é IGUAL ao código do produto
                if (Convert.ToString(codigo) == Convert.ToString(produto.Codigo))
                {
                    //Se for igual adiciona na lista
                    lista.Add(produto);
                }
            }

            return lista;
        }

        public static List<Produto> LocalizarProdutoPorParteNome(String parte)
        {
            return null;
        }
    }
}
