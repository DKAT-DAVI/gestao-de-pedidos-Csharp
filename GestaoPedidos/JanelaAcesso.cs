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
    public partial class JanelaAcesso : Form
    {
        private static JanelaAcesso instance;
        private JanelaAcesso()
        {
            InitializeComponent();
        }

        public static JanelaAcesso GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaAcesso();
            }

            return instance;
        }

        // Acessar a JanelaPrincipal
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            this.Hide();
            JanelaPrincipal.GetInstance().Show();
        }
    }
}
