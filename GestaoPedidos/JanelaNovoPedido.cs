using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPedidos
{
    public partial class JanelaNovoPedido : Form
    {
        // Criacao de uma variavel auxiliar para transportar os dados do pedido pricipal
        private Pedido _pedidoAuxiliar;

        private static JanelaNovoPedido instance;

        private JanelaNovoPedido()
        {
            InitializeComponent();

            // Iniciacao da variavel auxiliar
            _pedidoAuxiliar = new Pedido();
        }

        public static JanelaNovoPedido GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaNovoPedido();
            }

            return instance;
        }

        //Fechamento da JanelaPrincipal pelo botão cancelar
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Evento de busca pelo código do produto
        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            // Limpa o DataSource da lstProdutos
            lstProdutos.DataSource = null;

            // Limpa a lista de produtos para fazer a busca novamente
            lstProdutos.Items.Clear();

            // Verifica se a textBox não está vazia e se o código digitado é um código numérico
            if (txtCodigo.Text != String.Empty
                && Regex.IsMatch(txtCodigo.Text, "^[0-9]+$"))
            {
                // Verifica se o método LocalizarProdutoPorCodigo() está retornando null
                if (BancoDadosSimulado.LocalizarProdutoPorCodigo(Convert.ToInt64(txtCodigo.Text)) != null)
                {

                    // Adiciona o produto referente ao código digitado na lstProdutos
                    lstProdutos.Items.Add(BancoDadosSimulado.LocalizarProdutoPorCodigo(Convert.ToInt64(txtCodigo.Text)));

                    // Reseta a caixa de busca por nome
                    txtNome.Text = null;

                    // Seleciona o item na lstProdutos
                    lstProdutos.SelectedIndex = 0;

                }
            }
                    // Faz a verificação de habilitação do botão ACRESCENTAR
                    HabilitarBotaoAcrescentar();
        }


        // Evento de busca por parte do nome do produto
        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            // Limpa a txtBox de busca por código
            txtCodigo.Text = null;

            // O DataSource da lista de produtos recebe a lista retornada do método LocalizarProdutoPorParteNome()
            lstProdutos.DataSource = BancoDadosSimulado.LocalizarProdutoPorParteNome(txtNome.Text);
            
            // Limpa a caixa de busca por codigo
            txtCodigo.Text = null;

            // Faz a verificação de habilitação do botão ACRESCENTAR
            HabilitarBotaoAcrescentar();
        }


        // Evento de click no botão ACRESCENTAR
        private void btnAcrescentar_Click(object sender, EventArgs e)
        {
            // Cria um novo Item que vai receber os valores inseridos nos txtBox
            Item item = new Item(Convert.ToInt16(nudQuantidade.Value), (Produto)lstProdutos.SelectedItem);

            _pedidoAuxiliar.AdicionarItem(item);

            // Adiciona os itens na lista dos itens selecionados
            lstItens.Items.Add(item);

            //// Calcular preco da compra e alterar o lblTotal
            //TotalPedido();

            // Reseta os inserts dos txtBox para uma nova busca
            txtCodigo.Text = null;
            txtNome.Text = null;
            lstProdutos.DataSource = null;
            lstProdutos.Items.Clear();
            txtCodigo.Focus();
        }


        //Evento de click no botão SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Criação do pedido principal
            Pedido pedido = new Pedido();

            // Atribuicao dos itens do pedido auxiliar para lista de pedidos principal
            foreach (Item iten in _pedidoAuxiliar.Itens)
            {
                pedido.Itens.Add(iten);
            }

            // Armazenamento do pedido no BancoDados
            BancoDadosSimulado.Pedidos.Add(pedido);

            // Resetar a lista do pedido auxiliar
            _pedidoAuxiliar.Itens.Clear();

            // Resete do forms para acrescentar um novo pedido
            lstItens.Items.Clear();
            txtCodigo.Focus();
            lblTotal.Text = "Total: R$ ---";

        }


        // Habilitar e desabilitar o botão Acrescentar
        private void HabilitarBotaoAcrescentar()
        {
            // Se a lista de produtos estiver vazia, o botão fica desabilitado
            if (lstProdutos.Items.Count > 0)
            {
                btnAcrescentar.Enabled = true;
            }
            else
            {
                btnAcrescentar.Enabled = false;
            }
        }
    }
}
