using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPedidos
{
    public partial class JanelaPrincipal : Form
    {
        private static JanelaPrincipal instance;

        private JanelaPrincipal()
        {
            InitializeComponent();
            new BancoDadosSimulado();
        }

        public static JanelaPrincipal GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaPrincipal();
            }

            return instance;
        }

        //Fechando pelo MenuStrip
        private void mnuArquivoSair_Click(object sender, EventArgs e)
        {
            this.Close();
            JanelaAcesso.GetInstance().Show();
        }

        //Abrindo a JanelaProdutos
        private void mnuRelatorioProdutos_Click(object sender, EventArgs e)
        {
            JanelaProdutos j = JanelaProdutos.GetInstance();
            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();

                // Organiza as janelas verticalmente
                this.LayoutMdi(MdiLayout.TileVertical);
            }
            //Verificando se a janela está minimizada
            else
            {
                j.WindowState = FormWindowState.Normal;   
            }
            //Sobrepõe e dá foco na janela quando acionado o evento
            j.Activate();
        }

        private void mnuCadastroPedidos_Click(object sender, EventArgs e)
        {
            JanelaPedidos j = JanelaPedidos.GetInstance();
            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();

                // Organiza as janelas verticalmente
                this.LayoutMdi(MdiLayout.TileVertical);

            }
            //Verificando se a janela está minimizada
            else
            {
                j.WindowState = FormWindowState.Normal;
            }
            //Sobrepõe e dá foco na janela quando acionado o evento
            j.Activate();
        }

        private void JanelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            JanelaAcesso.GetInstance().Show();
        }
    }
}
