namespace GestaoPedidos
{
    partial class JanelaProdutos
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
            this.pnlProdutos = new System.Windows.Forms.Panel();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.pnlProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProdutos
            // 
            this.pnlProdutos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlProdutos.Controls.Add(this.lstProdutos);
            this.pnlProdutos.Location = new System.Drawing.Point(0, 0);
            this.pnlProdutos.Name = "pnlProdutos";
            this.pnlProdutos.Size = new System.Drawing.Size(270, 372);
            this.pnlProdutos.TabIndex = 0;
            // 
            // lstProdutos
            // 
            this.lstProdutos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstProdutos.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.ItemHeight = 23;
            this.lstProdutos.Location = new System.Drawing.Point(16, 9);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(238, 349);
            this.lstProdutos.TabIndex = 0;
            // 
            // JanelaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 370);
            this.Controls.Add(this.pnlProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JanelaProdutos";
            this.Text = "Produtos";
            this.pnlProdutos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProdutos;
        private System.Windows.Forms.ListBox lstProdutos;
    }
}