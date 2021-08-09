
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
            this.btnFiltroContas = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSaldoTotal = new System.Windows.Forms.TextBox();
            this.txtMaiorSaldo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // btnFiltroContas
            // 
            this.btnFiltroContas.Location = new System.Drawing.Point(122, 63);
            this.btnFiltroContas.Name = "btnFiltroContas";
            this.btnFiltroContas.Size = new System.Drawing.Size(72, 23);
            this.btnFiltroContas.TabIndex = 1;
            this.btnFiltroContas.Text = "Busca";
            this.btnFiltroContas.UseVisualStyleBackColor = true;
            this.btnFiltroContas.Click += new System.EventHandler(this.btnFiltroContas_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(60, 26);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(93, 23);
            this.txtValor.TabIndex = 2;
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Location = new System.Drawing.Point(221, 27);
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(93, 23);
            this.txtNumeroConta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Saldo >";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número <";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumeroConta);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.btnFiltroContas);
            this.groupBox1.Location = new System.Drawing.Point(12, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 99);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Contas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaiorSaldo);
            this.groupBox2.Controls.Add(this.txtSaldoTotal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 106);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resumo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Saldo Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Maior Saldo";
            // 
            // txtSaldoTotal
            // 
            this.txtSaldoTotal.Enabled = false;
            this.txtSaldoTotal.Location = new System.Drawing.Point(165, 27);
            this.txtSaldoTotal.Name = "txtSaldoTotal";
            this.txtSaldoTotal.Size = new System.Drawing.Size(93, 23);
            this.txtSaldoTotal.TabIndex = 7;
            this.txtSaldoTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMaiorSaldo
            // 
            this.txtMaiorSaldo.Enabled = false;
            this.txtMaiorSaldo.Location = new System.Drawing.Point(165, 63);
            this.txtMaiorSaldo.Name = "txtMaiorSaldo";
            this.txtMaiorSaldo.Size = new System.Drawing.Size(93, 23);
            this.txtMaiorSaldo.TabIndex = 8;
            this.txtMaiorSaldo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstResultado);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.Load += new System.EventHandler(this.FormRelatorios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Button btnFiltroContas;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNumeroConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaiorSaldo;
        private System.Windows.Forms.TextBox txtSaldoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}