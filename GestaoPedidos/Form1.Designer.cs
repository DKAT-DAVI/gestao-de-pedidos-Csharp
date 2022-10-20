namespace GestaoPedidos
{
    partial class JanelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorioProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.mnuCadastro,
            this.mnuRelatorio});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivoSair});
            this.mnuArquivo.ForeColor = System.Drawing.Color.Black;
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnuArquivo.Text = "Arquivo";
            // 
            // mnuArquivoSair
            // 
            this.mnuArquivoSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuArquivoSair.Name = "mnuArquivoSair";
            this.mnuArquivoSair.Size = new System.Drawing.Size(93, 22);
            this.mnuArquivoSair.Text = "Sair";
            this.mnuArquivoSair.Click += new System.EventHandler(this.mnuArquivoSair_Click);
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroPedidos});
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(66, 20);
            this.mnuCadastro.Text = "Cadastro";
            // 
            // mnuCadastroPedidos
            // 
            this.mnuCadastroPedidos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuCadastroPedidos.Name = "mnuCadastroPedidos";
            this.mnuCadastroPedidos.Size = new System.Drawing.Size(116, 22);
            this.mnuCadastroPedidos.Text = "Pedidos";
            this.mnuCadastroPedidos.Click += new System.EventHandler(this.mnuCadastroPedidos_Click);
            // 
            // mnuRelatorio
            // 
            this.mnuRelatorio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRelatorioProdutos});
            this.mnuRelatorio.Name = "mnuRelatorio";
            this.mnuRelatorio.Size = new System.Drawing.Size(66, 20);
            this.mnuRelatorio.Text = "Relatório";
            // 
            // mnuRelatorioProdutos
            // 
            this.mnuRelatorioProdutos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuRelatorioProdutos.Name = "mnuRelatorioProdutos";
            this.mnuRelatorioProdutos.Size = new System.Drawing.Size(122, 22);
            this.mnuRelatorioProdutos.Text = "Produtos";
            this.mnuRelatorioProdutos.Click += new System.EventHandler(this.mnuRelatorioProdutos_Click);
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(50, 50);
            this.Name = "JanelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Pedidos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JanelaPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivoSair;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroPedidos;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorioProdutos;
    }
}

