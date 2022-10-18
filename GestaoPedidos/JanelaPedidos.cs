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
    public partial class JanelaPedidos : Form
    {
        private static JanelaPedidos instance;

        private JanelaPedidos()
        {
            InitializeComponent();
        }

        public static JanelaPedidos GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaPedidos();
            }
            return instance;
        }

        //Chamando a JanleaNovoPedido
        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            JanelaNovoPedido j = JanelaNovoPedido.GetInstance();
            if (j.MdiParent == null)
            {
                j.MdiParent = this.MdiParent;
                j.Show();

            }
            else
            {
                j.WindowState = FormWindowState.Normal;
            }
            j.Activate();
        }
    }
}
