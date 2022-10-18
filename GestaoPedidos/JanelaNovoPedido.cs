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

        //Evento de click no botão SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
        }

        //Buscando pelo código
        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            //Verifica se a textBox não está vazia e se o código digitado é um código numérico
            if (txtCodigo.Text != String.Empty
                && Regex.IsMatch(txtCodigo.Text, "^[0-9]+$"))
            {
                //Se for, o DataSource da lista de produtos recebe a lista com o produto buscado
                lstProdutos.DataSource = BancoDadosSimulado.LocalizarProdutoPorCodigo(Convert.ToInt64(txtCodigo.Text));
                
                //E habilita o botão acrescentar
                if (lstProdutos.SelectedItems.Count > 0)
                {
                    btnAcrescentar.Enabled = true;
                }
            }

            //Se não o DataSource da lista de produtos fica nula
            else
            {
                lstProdutos.DataSource = null;
            }
        }
    }
}
