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
        private static JanelaNovoPedido instance;

        private JanelaNovoPedido()
        {
            InitializeComponent();
        }

        public static JanelaNovoPedido GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaNovoPedido();
            }

            return instance;
        }

        //Fechamento pelo botão cancelar
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento de busca pelo código do produto
        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            //Verifica se a textBox não está vazia e se o código digitado é um código numérico
            if (txtCodigo.Text != String.Empty
                && Regex.IsMatch(txtCodigo.Text, "^[0-9]+$"))
            {
                //Se for, o DataSource da lista de produtos recebe a lista com o produto buscado
                lstProdutos.DataSource = BancoDadosSimulado.LocalizarProdutoPorCodigo(Convert.ToInt64(txtCodigo.Text));
                HabilitarBotaoAcrescentar();
            }

            //Se não o DataSource da lista de produtos fica nula
            else
            {
                lstProdutos.DataSource = null;
                HabilitarBotaoAcrescentar();
            }
        }

        // Evento de busca por parte do nome do produto
        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            lstProdutos.DataSource = BancoDadosSimulado.LocalizarProdutoPorParteNome(txtNome.Text);
            HabilitarBotaoAcrescentar();
        }

        // Evento de click no botão ACRESCENTAR
        private void btnAcrescentar_Click(object sender, EventArgs e)
        {
            // Cria um novo Item que vai receber os valores inseridos nos txtBox
            Item item = new Item(Convert.ToInt16(nudQuantidade.Value), (Produto)lstProdutos.SelectedItem);           
            // Adiciona os itens na lista dos itens selecionados
            lstItens.Items.Add(item);

            // Cria um novo pedido 
            Pedido pedido = new Pedido();
            // Faz uma iteração na lista de itens selecionados e adiciona todos eles na lista de itens do pedido
            foreach (Item produto in lstItens.Items)
            {
                pedido.Itens.Add(produto);
            }

            // Muda o total da compra da interface
            lblTotal.Text = $"Total: R$ {pedido.CalcularTotal()}";

            // Reseta os inserts dos txtBox para uma nova busca
            txtCodigo.Text = null;
            txtNome.Text = null;
            lstProdutos.DataSource = null;
            txtCodigo.Focus();
        }

        //Evento de click no botão SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        //Habilitar e desabilitar o botão Acrescentar
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
