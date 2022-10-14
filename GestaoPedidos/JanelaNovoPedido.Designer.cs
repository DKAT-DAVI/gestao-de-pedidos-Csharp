namespace GestaoPedidos
{
    partial class JanelaNovoPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNovoPedido = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAcrescentar = new System.Windows.Forms.Button();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.lstItens = new System.Windows.Forms.ListBox();
            this.lblItens = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.pnlNovoPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNovoPedido
            // 
            this.pnlNovoPedido.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlNovoPedido.Controls.Add(this.lblTotal);
            this.pnlNovoPedido.Controls.Add(this.btnCancelar);
            this.pnlNovoPedido.Controls.Add(this.btnSalvar);
            this.pnlNovoPedido.Controls.Add(this.btnAcrescentar);
            this.pnlNovoPedido.Controls.Add(this.nudQuantidade);
            this.pnlNovoPedido.Controls.Add(this.txtNome);
            this.pnlNovoPedido.Controls.Add(this.txtCodigo);
            this.pnlNovoPedido.Controls.Add(this.lstProdutos);
            this.pnlNovoPedido.Controls.Add(this.lstItens);
            this.pnlNovoPedido.Controls.Add(this.lblItens);
            this.pnlNovoPedido.Controls.Add(this.lblQuantidade);
            this.pnlNovoPedido.Controls.Add(this.lblNome);
            this.pnlNovoPedido.Controls.Add(this.lblCodigo);
            this.pnlNovoPedido.Controls.Add(this.lblProduto);
            this.pnlNovoPedido.Location = new System.Drawing.Point(-1, -1);
            this.pnlNovoPedido.Name = "pnlNovoPedido";
            this.pnlNovoPedido.Size = new System.Drawing.Size(588, 267);
            this.pnlNovoPedido.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(233, 214);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 24);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total: R$ ---";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(426, 211);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 31);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(512, 211);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 31);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAcrescentar
            // 
            this.btnAcrescentar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAcrescentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcrescentar.ForeColor = System.Drawing.Color.White;
            this.btnAcrescentar.Location = new System.Drawing.Point(113, 226);
            this.btnAcrescentar.Name = "btnAcrescentar";
            this.btnAcrescentar.Size = new System.Drawing.Size(102, 31);
            this.btnAcrescentar.TabIndex = 10;
            this.btnAcrescentar.Text = "ACRESCENTAR";
            this.btnAcrescentar.UseVisualStyleBackColor = false;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nudQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidade.Location = new System.Drawing.Point(105, 195);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(119, 26);
            this.nudQuantidade.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(71, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(153, 26);
            this.txtNome.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(72, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(152, 26);
            this.txtCodigo.TabIndex = 7;
            // 
            // lstProdutos
            // 
            this.lstProdutos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.ItemHeight = 20;
            this.lstProdutos.Location = new System.Drawing.Point(15, 104);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(209, 84);
            this.lstProdutos.TabIndex = 6;
            // 
            // lstItens
            // 
            this.lstItens.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItens.FormattingEnabled = true;
            this.lstItens.ItemHeight = 20;
            this.lstItens.Location = new System.Drawing.Point(230, 39);
            this.lstItens.Name = "lstItens";
            this.lstItens.Size = new System.Drawing.Size(347, 164);
            this.lstItens.TabIndex = 5;
            // 
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            this.lblItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItens.ForeColor = System.Drawing.Color.White;
            this.lblItens.Location = new System.Drawing.Point(229, 11);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(59, 25);
            this.lblItens.TabIndex = 4;
            this.lblItens.Text = "Itens";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 198);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(96, 20);
            this.lblQuantidade.TabIndex = 3;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(12, 76);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(12, 43);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.Color.White;
            this.lblProduto.Location = new System.Drawing.Point(12, 11);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(87, 25);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto";
            // 
            // JanelaNovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 264);
            this.Controls.Add(this.pnlNovoPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JanelaNovoPedido";
            this.Text = "Cadastro de Item";
            this.pnlNovoPedido.ResumeLayout(false);
            this.pnlNovoPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNovoPedido;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ListBox lstItens;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAcrescentar;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}