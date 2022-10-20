namespace GestaoPedidos
{
    partial class JanelaAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaAcesso));
            this.pnlAcesso = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.pnlAcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAcesso
            // 
            this.pnlAcesso.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlAcesso.Controls.Add(this.label2);
            this.pnlAcesso.Controls.Add(this.lblTitulo);
            this.pnlAcesso.Controls.Add(this.btnAcessar);
            this.pnlAcesso.Location = new System.Drawing.Point(-2, 0);
            this.pnlAcesso.Name = "pnlAcesso";
            this.pnlAcesso.Size = new System.Drawing.Size(802, 451);
            this.pnlAcesso.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(301, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sistema de gerenciamento de pedidos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(247, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(327, 156);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "DKAT\r\nSistemas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAcessar.Location = new System.Drawing.Point(311, 248);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(198, 79);
            this.btnAcessar.TabIndex = 0;
            this.btnAcessar.Text = "ACESSAR";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // JanelaAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAcesso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JanelaAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Pedidos";
            this.pnlAcesso.ResumeLayout(false);
            this.pnlAcesso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAcesso;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Label label2;
    }
}