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
    public partial class JanelaProdutos : Form
    {
        private static JanelaProdutos instance;
        private JanelaProdutos()
        {
            InitializeComponent();

            //Lista de Produtos recebe os produtos inseridos no BancoDeDadosSimulado
            lstProdutos.DataSource = BancoDadosSimulado.Produtos;
        }

        public static JanelaProdutos GetInstance()
        {
            if ( instance == null || instance.IsDisposed)
            {
                instance = new JanelaProdutos();
            }
            return instance;
        }
    }
}
