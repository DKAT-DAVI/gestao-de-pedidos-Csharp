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
            Produto p1 = new Produto(1, "Abacaxi", 12.20m);
            Produto p2 = new Produto(2, "Batata-Palha", 7.00m);
            Produto p3 = new Produto(3, "Cheiro-Verde", 2.00m);
            Produto p4 = new Produto(4, "Desinfetante", 6.00m);
            Produto p5 = new Produto(5, "Esfregão", 18.00m);
            Produto p6 = new Produto(6, "Farinha", 8.00m);
            Produto p7 = new Produto(7, "Gengibre", 15.50m);
            Produto p8 = new Produto(8, "Hortelã", 2.50m);
            Produto p9 = new Produto(9, "Iogurte", 4.50m);
            Produto p10 = new Produto(10, "Jambo", 5.50m);

            //Adicionando lista de produtos ao BancoDadosSimulado
            Produtos.Add(p1);
            Produtos.Add(p2);
            Produtos.Add(p3);
            Produtos.Add(p4);
            Produtos.Add(p5);
            Produtos.Add(p6);
            Produtos.Add(p7);
            Produtos.Add(p8);
            Produtos.Add(p9);
            Produtos.Add(p10);
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
                if (codigo == produto.Codigo)
                {
                    //Se for igual adiciona na lista
                    lista.Add(produto);
                }
            }

            //Retorna a lista
            return lista;
        }

        public static List<Produto> LocalizarProdutoPorParteNome(String parte)
        {
            //Cria uma lista para armazenar os produtos buscados
            List<Produto> lista = new List<Produto>();

            //Varre a lista de Produtos existentes no BancoDadosSimulado
            foreach (Produto produto in Produtos)
            {
                //Verifica se a string buscada faz parte do nome de algum produto
                if (produto.Nome.ToLower().Contains(parte.ToLower()))
                {
                    //Adiciona na lista de produtos
                    lista.Add(produto);
                }
            }

            //Retorna a lista com os elementos selecionados
            return lista;
        }
    }
}
