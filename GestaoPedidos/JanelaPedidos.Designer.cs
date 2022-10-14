namespace GestaoPedidos
{
    partial class JanelaPedidos
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
            this.pnlPedidos = new System.Windows.Forms.Panel();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.lstPedidos = new System.Windows.Forms.ListBox();
            this.pnlPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPedidos
            // 
            this.pnlPedidos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlPedidos.Controls.Add(this.btnNovoPedido);
            this.pnlPedidos.Controls.Add(this.lstPedidos);
            this.pnlPedidos.Location = new System.Drawing.Point(-3, -2);
            this.pnlPedidos.Name = "pnlPedidos";
            this.pnlPedidos.Size = new System.Drawing.Size(277, 387);
            this.pnlPedidos.TabIndex = 0;
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNovoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPedido.ForeColor = System.Drawing.Color.White;
            this.btnNovoPedido.Location = new System.Drawing.Point(19, 319);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(238, 48);
            this.btnNovoPedido.TabIndex = 2;
            this.btnNovoPedido.Text = "NOVO PEDIDO";
            this.btnNovoPedido.UseVisualStyleBackColor = false;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // lstPedidos
            // 
            this.lstPedidos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstPedidos.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPedidos.FormattingEnabled = true;
            this.lstPedidos.ItemHeight = 23;
            this.lstPedidos.Location = new System.Drawing.Point(19, 9);
            this.lstPedidos.Name = "lstPedidos";
            this.lstPedidos.Size = new System.Drawing.Size(238, 303);
            this.lstPedidos.TabIndex = 1;
            // 
            // JanelaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 370);
            this.Controls.Add(this.pnlPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JanelaPedidos";
            this.Text = "Pedidos";
            this.pnlPedidos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPedidos;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.ListBox lstPedidos;
    }
}