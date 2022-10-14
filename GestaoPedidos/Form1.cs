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
        public JanelaPrincipal()
        {
            InitializeComponent();
        }

        private void mnuArquivoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuRelatorioProdutos_Click(object sender, EventArgs e)
        {
            JanelaProdutos j = JanelaProdutos.GetInstance();
            j.MdiParent = this;
            j.Show();
        }

        private void mnuCadastroPedidos_Click(object sender, EventArgs e)
        {
            JanelaPedidos j = JanelaPedidos.GetInstance();
            j.MdiParent = this;
            j.Show();
        }
    }
}
