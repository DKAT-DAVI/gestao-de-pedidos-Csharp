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

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            JanelaNovoPedido j = JanelaNovoPedido.GetInstance();
            j.MdiParent = this.MdiParent;
            j.Show();
        }
    }
}
