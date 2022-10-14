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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto(111, "Abacaxi", 12);

            Item i = new Item(2, p);

            Console.WriteLine(i);
        }
    }
}
