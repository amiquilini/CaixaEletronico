﻿
namespace CaixaEletronico
{
    partial class FormCaixaEletronico
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcularTributo = new System.Windows.Forms.Button();
            this.labelContas = new System.Windows.Forms.Label();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.gbBuscaConta = new System.Windows.Forms.GroupBox();
            this.btnBuscaConta = new System.Windows.Forms.Button();
            this.lblTitularBusca = new System.Windows.Forms.Label();
            this.txtBuscaTitular = new System.Windows.Forms.TextBox();
            this.lblContaDestino = new System.Windows.Forms.Label();
            this.comboDestinoTransferencia = new System.Windows.Forms.ComboBox();
            this.gbTransferencia = new System.Windows.Forms.GroupBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.btnNovaConta = new System.Windows.Forms.Button();
            this.btnTotalizarContas = new System.Windows.Forms.Button();
            this.btnTotalizarTributos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gbBuscaConta.SuspendLayout();
            this.gbTransferencia.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(180, 51);
            this.txtTitular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(235, 31);
            this.txtTitular.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(179, 109);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(236, 31);
            this.txtNumero.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(173, 65);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(235, 31);
            this.txtValor.TabIndex = 6;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(179, 169);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(236, 31);
            this.txtSaldo.TabIndex = 7;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(173, 121);
            this.btnDepositar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(107, 38);
            this.btnDepositar.TabIndex = 8;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(301, 121);
            this.btnSacar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(107, 38);
            this.btnSacar.TabIndex = 9;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcularTributo);
            this.groupBox1.Controls.Add(this.txtTitular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Location = new System.Drawing.Point(18, 169);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(455, 291);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // btnCalcularTributo
            // 
            this.btnCalcularTributo.Location = new System.Drawing.Point(218, 226);
            this.btnCalcularTributo.Name = "btnCalcularTributo";
            this.btnCalcularTributo.Size = new System.Drawing.Size(163, 38);
            this.btnCalcularTributo.TabIndex = 8;
            this.btnCalcularTributo.Text = "Calcular Tributo";
            this.btnCalcularTributo.UseVisualStyleBackColor = true;
            this.btnCalcularTributo.Click += new System.EventHandler(this.btnCalcularTributo_Click);
            // 
            // labelContas
            // 
            this.labelContas.AutoSize = true;
            this.labelContas.Location = new System.Drawing.Point(31, 42);
            this.labelContas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContas.Name = "labelContas";
            this.labelContas.Size = new System.Drawing.Size(134, 25);
            this.labelContas.TabIndex = 9;
            this.labelContas.Text = "Escolha a conta";
            // 
            // comboContas
            // 
            this.comboContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(179, 39);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(236, 33);
            this.comboContas.TabIndex = 8;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // gbBuscaConta
            // 
            this.gbBuscaConta.Controls.Add(this.btnBuscaConta);
            this.gbBuscaConta.Controls.Add(this.labelContas);
            this.gbBuscaConta.Controls.Add(this.lblTitularBusca);
            this.gbBuscaConta.Controls.Add(this.txtBuscaTitular);
            this.gbBuscaConta.Controls.Add(this.comboContas);
            this.gbBuscaConta.Location = new System.Drawing.Point(18, 17);
            this.gbBuscaConta.Name = "gbBuscaConta";
            this.gbBuscaConta.Size = new System.Drawing.Size(455, 148);
            this.gbBuscaConta.TabIndex = 11;
            this.gbBuscaConta.TabStop = false;
            this.gbBuscaConta.Text = "Conta";
            // 
            // btnBuscaConta
            // 
            this.btnBuscaConta.Location = new System.Drawing.Point(325, 90);
            this.btnBuscaConta.Name = "btnBuscaConta";
            this.btnBuscaConta.Size = new System.Drawing.Size(90, 37);
            this.btnBuscaConta.TabIndex = 18;
            this.btnBuscaConta.Text = "Buscar";
            this.btnBuscaConta.UseVisualStyleBackColor = true;
            this.btnBuscaConta.Click += new System.EventHandler(this.btnBuscaConta_Click);
            // 
            // lblTitularBusca
            // 
            this.lblTitularBusca.AutoSize = true;
            this.lblTitularBusca.Location = new System.Drawing.Point(32, 96);
            this.lblTitularBusca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitularBusca.Name = "lblTitularBusca";
            this.lblTitularBusca.Size = new System.Drawing.Size(140, 25);
            this.lblTitularBusca.TabIndex = 9;
            this.lblTitularBusca.Text = "Busca por titular";
            // 
            // txtBuscaTitular
            // 
            this.txtBuscaTitular.Location = new System.Drawing.Point(179, 93);
            this.txtBuscaTitular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscaTitular.Name = "txtBuscaTitular";
            this.txtBuscaTitular.Size = new System.Drawing.Size(139, 31);
            this.txtBuscaTitular.TabIndex = 10;
            // 
            // lblContaDestino
            // 
            this.lblContaDestino.AutoSize = true;
            this.lblContaDestino.Location = new System.Drawing.Point(8, 47);
            this.lblContaDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContaDestino.Name = "lblContaDestino";
            this.lblContaDestino.Size = new System.Drawing.Size(123, 25);
            this.lblContaDestino.TabIndex = 9;
            this.lblContaDestino.Text = "Conta destino";
            // 
            // comboDestinoTransferencia
            // 
            this.comboDestinoTransferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDestinoTransferencia.FormattingEnabled = true;
            this.comboDestinoTransferencia.Location = new System.Drawing.Point(156, 44);
            this.comboDestinoTransferencia.Name = "comboDestinoTransferencia";
            this.comboDestinoTransferencia.Size = new System.Drawing.Size(236, 33);
            this.comboDestinoTransferencia.TabIndex = 8;
            this.comboDestinoTransferencia.SelectedIndexChanged += new System.EventHandler(this.comboDestinoTransferencia_SelectedIndexChanged);
            // 
            // gbTransferencia
            // 
            this.gbTransferencia.Controls.Add(this.btnTransferir);
            this.gbTransferencia.Controls.Add(this.lblContaDestino);
            this.gbTransferencia.Controls.Add(this.comboDestinoTransferencia);
            this.gbTransferencia.Location = new System.Drawing.Point(16, 181);
            this.gbTransferencia.Name = "gbTransferencia";
            this.gbTransferencia.Size = new System.Drawing.Size(424, 165);
            this.gbTransferencia.TabIndex = 12;
            this.gbTransferencia.TabStop = false;
            this.gbTransferencia.Text = "Transferência";
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(156, 102);
            this.btnTransferir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(236, 38);
            this.btnTransferir.TabIndex = 10;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMoeda);
            this.groupBox2.Controls.Add(this.gbTransferencia);
            this.groupBox2.Controls.Add(this.btnSacar);
            this.groupBox2.Controls.Add(this.btnDepositar);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(492, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 402);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operações";
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(131, 68);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(33, 25);
            this.lblMoeda.TabIndex = 13;
            this.lblMoeda.Text = "R$";
            // 
            // btnNovaConta
            // 
            this.btnNovaConta.Location = new System.Drawing.Point(159, 488);
            this.btnNovaConta.Name = "btnNovaConta";
            this.btnNovaConta.Size = new System.Drawing.Size(163, 42);
            this.btnNovaConta.TabIndex = 14;
            this.btnNovaConta.Text = "Nova Conta";
            this.btnNovaConta.UseVisualStyleBackColor = true;
            this.btnNovaConta.Click += new System.EventHandler(this.btnNovaConta_Click);
            // 
            // btnTotalizarContas
            // 
            this.btnTotalizarContas.Location = new System.Drawing.Point(54, 42);
            this.btnTotalizarContas.Name = "btnTotalizarContas";
            this.btnTotalizarContas.Size = new System.Drawing.Size(164, 42);
            this.btnTotalizarContas.TabIndex = 15;
            this.btnTotalizarContas.Text = "Totalizar Contas";
            this.btnTotalizarContas.UseVisualStyleBackColor = true;
            this.btnTotalizarContas.Click += new System.EventHandler(this.btnTotalizarContas_Click);
            // 
            // btnTotalizarTributos
            // 
            this.btnTotalizarTributos.Location = new System.Drawing.Point(235, 42);
            this.btnTotalizarTributos.Name = "btnTotalizarTributos";
            this.btnTotalizarTributos.Size = new System.Drawing.Size(165, 42);
            this.btnTotalizarTributos.TabIndex = 16;
            this.btnTotalizarTributos.Text = "Totalizar Tributos";
            this.btnTotalizarTributos.UseVisualStyleBackColor = true;
            this.btnTotalizarTributos.Click += new System.EventHandler(this.btnTotalizarTributos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTotalizarTributos);
            this.groupBox3.Controls.Add(this.btnTotalizarContas);
            this.groupBox3.Location = new System.Drawing.Point(492, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 115);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totalizadores";
            // 
            // FormCaixaEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 557);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnNovaConta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbBuscaConta);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormCaixaEletronico";
            this.Text = "Caixa Eletrônico";
            this.Load += new System.EventHandler(this.FormCaixaEletronico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbBuscaConta.ResumeLayout(false);
            this.gbBuscaConta.PerformLayout();
            this.gbTransferencia.ResumeLayout(false);
            this.gbTransferencia.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelContas;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.GroupBox gbBuscaConta;
        private System.Windows.Forms.Label lblContaDestino;
        private System.Windows.Forms.ComboBox comboDestinoTransferencia;
        private System.Windows.Forms.GroupBox gbTransferencia;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNovaConta;
        private System.Windows.Forms.Label lblMoeda;
        private System.Windows.Forms.Button btnTotalizarContas;
        private System.Windows.Forms.Button btnTotalizarTributos;
        private System.Windows.Forms.Button btnCalcularTributo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuscaTitular;
        private System.Windows.Forms.Label lblTitularBusca;
        private System.Windows.Forms.Button btnBuscaConta;
    }
}
