
namespace CaixaEletronico.Forms
{
    partial class FormRelatorios
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
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.btnFiltroSaldo = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.ItemHeight = 15;
            this.lstResultado.Location = new System.Drawing.Point(12, 12);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(322, 169);
            this.lstResultado.TabIndex = 0;
            // 
            // btnFiltroSaldo
            // 
            this.btnFiltroSaldo.Location = new System.Drawing.Point(127, 187);
            this.btnFiltroSaldo.Name = "btnFiltroSaldo";
            this.btnFiltroSaldo.Size = new System.Drawing.Size(82, 23);
            this.btnFiltroSaldo.TabIndex = 1;
            this.btnFiltroSaldo.Text = "Saldo >";
            this.btnFiltroSaldo.UseVisualStyleBackColor = true;
            this.btnFiltroSaldo.Click += new System.EventHandler(this.btnFiltroSaldo_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(215, 187);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(118, 23);
            this.txtValor.TabIndex = 2;
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 220);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnFiltroSaldo);
            this.Controls.Add(this.lstResultado);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.Load += new System.EventHandler(this.FormRelatorios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Button btnFiltroSaldo;
        private System.Windows.Forms.TextBox txtValor;
    }
}