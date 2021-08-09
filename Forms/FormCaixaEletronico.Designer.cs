
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
            this.btnRelatorios = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(126, 31);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(166, 23);
            this.txtTitular.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(125, 65);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(166, 23);
            this.txtNumero.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(121, 39);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(166, 23);
            this.txtValor.TabIndex = 6;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(125, 101);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(166, 23);
            this.txtSaldo.TabIndex = 7;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(121, 73);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(75, 23);
            this.btnDepositar.TabIndex = 8;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(211, 73);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 175);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // btnCalcularTributo
            // 
            this.btnCalcularTributo.Location = new System.Drawing.Point(153, 136);
            this.btnCalcularTributo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcularTributo.Name = "btnCalcularTributo";
            this.btnCalcularTributo.Size = new System.Drawing.Size(114, 23);
            this.btnCalcularTributo.TabIndex = 8;
            this.btnCalcularTributo.Text = "Calcular Tributo";
            this.btnCalcularTributo.UseVisualStyleBackColor = true;
            this.btnCalcularTributo.Click += new System.EventHandler(this.btnCalcularTributo_Click);
            // 
            // labelContas
            // 
            this.labelContas.AutoSize = true;
            this.labelContas.Location = new System.Drawing.Point(22, 25);
            this.labelContas.Name = "labelContas";
            this.labelContas.Size = new System.Drawing.Size(89, 15);
            this.labelContas.TabIndex = 9;
            this.labelContas.Text = "Escolha a conta";
            // 
            // comboContas
            // 
            this.comboContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(125, 23);
            this.comboContas.Margin = new System.Windows.Forms.Padding(2);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(166, 23);
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
            this.gbBuscaConta.Location = new System.Drawing.Point(13, 10);
            this.gbBuscaConta.Margin = new System.Windows.Forms.Padding(2);
            this.gbBuscaConta.Name = "gbBuscaConta";
            this.gbBuscaConta.Padding = new System.Windows.Forms.Padding(2);
            this.gbBuscaConta.Size = new System.Drawing.Size(318, 89);
            this.gbBuscaConta.TabIndex = 11;
            this.gbBuscaConta.TabStop = false;
            this.gbBuscaConta.Text = "Conta";
            // 
            // btnBuscaConta
            // 
            this.btnBuscaConta.Location = new System.Drawing.Point(228, 56);
            this.btnBuscaConta.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscaConta.Name = "btnBuscaConta";
            this.btnBuscaConta.Size = new System.Drawing.Size(63, 23);
            this.btnBuscaConta.TabIndex = 18;
            this.btnBuscaConta.Text = "Buscar";
            this.btnBuscaConta.UseVisualStyleBackColor = true;
            this.btnBuscaConta.Click += new System.EventHandler(this.btnBuscaConta_Click);
            // 
            // lblTitularBusca
            // 
            this.lblTitularBusca.AutoSize = true;
            this.lblTitularBusca.Location = new System.Drawing.Point(22, 58);
            this.lblTitularBusca.Name = "lblTitularBusca";
            this.lblTitularBusca.Size = new System.Drawing.Size(93, 15);
            this.lblTitularBusca.TabIndex = 9;
            this.lblTitularBusca.Text = "Busca por titular";
            // 
            // txtBuscaTitular
            // 
            this.txtBuscaTitular.Location = new System.Drawing.Point(125, 56);
            this.txtBuscaTitular.Name = "txtBuscaTitular";
            this.txtBuscaTitular.Size = new System.Drawing.Size(98, 23);
            this.txtBuscaTitular.TabIndex = 10;
            // 
            // lblContaDestino
            // 
            this.lblContaDestino.AutoSize = true;
            this.lblContaDestino.Location = new System.Drawing.Point(6, 28);
            this.lblContaDestino.Name = "lblContaDestino";
            this.lblContaDestino.Size = new System.Drawing.Size(81, 15);
            this.lblContaDestino.TabIndex = 9;
            this.lblContaDestino.Text = "Conta destino";
            // 
            // comboDestinoTransferencia
            // 
            this.comboDestinoTransferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDestinoTransferencia.FormattingEnabled = true;
            this.comboDestinoTransferencia.Location = new System.Drawing.Point(109, 26);
            this.comboDestinoTransferencia.Margin = new System.Windows.Forms.Padding(2);
            this.comboDestinoTransferencia.Name = "comboDestinoTransferencia";
            this.comboDestinoTransferencia.Size = new System.Drawing.Size(166, 23);
            this.comboDestinoTransferencia.TabIndex = 8;
            this.comboDestinoTransferencia.SelectedIndexChanged += new System.EventHandler(this.comboDestinoTransferencia_SelectedIndexChanged);
            // 
            // gbTransferencia
            // 
            this.gbTransferencia.Controls.Add(this.btnTransferir);
            this.gbTransferencia.Controls.Add(this.lblContaDestino);
            this.gbTransferencia.Controls.Add(this.comboDestinoTransferencia);
            this.gbTransferencia.Location = new System.Drawing.Point(11, 109);
            this.gbTransferencia.Margin = new System.Windows.Forms.Padding(2);
            this.gbTransferencia.Name = "gbTransferencia";
            this.gbTransferencia.Padding = new System.Windows.Forms.Padding(2);
            this.gbTransferencia.Size = new System.Drawing.Size(297, 99);
            this.gbTransferencia.TabIndex = 12;
            this.gbTransferencia.TabStop = false;
            this.gbTransferencia.Text = "Transferência";
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(109, 61);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(165, 23);
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
            this.groupBox2.Location = new System.Drawing.Point(13, 276);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(318, 218);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operações";
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(92, 41);
            this.lblMoeda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(20, 15);
            this.lblMoeda.TabIndex = 13;
            this.lblMoeda.Text = "R$";
            // 
            // btnNovaConta
            // 
            this.btnNovaConta.Location = new System.Drawing.Point(353, 26);
            this.btnNovaConta.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovaConta.Name = "btnNovaConta";
            this.btnNovaConta.Size = new System.Drawing.Size(114, 25);
            this.btnNovaConta.TabIndex = 14;
            this.btnNovaConta.Text = "Nova Conta";
            this.btnNovaConta.UseVisualStyleBackColor = true;
            this.btnNovaConta.Click += new System.EventHandler(this.btnNovaConta_Click);
            // 
            // btnTotalizarContas
            // 
            this.btnTotalizarContas.Location = new System.Drawing.Point(14, 20);
            this.btnTotalizarContas.Margin = new System.Windows.Forms.Padding(2);
            this.btnTotalizarContas.Name = "btnTotalizarContas";
            this.btnTotalizarContas.Size = new System.Drawing.Size(107, 25);
            this.btnTotalizarContas.TabIndex = 15;
            this.btnTotalizarContas.Text = "Totalizar Contas";
            this.btnTotalizarContas.UseVisualStyleBackColor = true;
            this.btnTotalizarContas.Click += new System.EventHandler(this.btnTotalizarContas_Click);
            // 
            // btnTotalizarTributos
            // 
            this.btnTotalizarTributos.Location = new System.Drawing.Point(14, 50);
            this.btnTotalizarTributos.Margin = new System.Windows.Forms.Padding(2);
            this.btnTotalizarTributos.Name = "btnTotalizarTributos";
            this.btnTotalizarTributos.Size = new System.Drawing.Size(107, 25);
            this.btnTotalizarTributos.TabIndex = 16;
            this.btnTotalizarTributos.Text = "Totalizar Tributos";
            this.btnTotalizarTributos.UseVisualStyleBackColor = true;
            this.btnTotalizarTributos.Click += new System.EventHandler(this.btnTotalizarTributos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTotalizarTributos);
            this.groupBox3.Controls.Add(this.btnTotalizarContas);
            this.groupBox3.Location = new System.Drawing.Point(342, 101);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(135, 86);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totalizadores";
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Location = new System.Drawing.Point(353, 60);
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(2);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(114, 25);
            this.btnRelatorios.TabIndex = 18;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // FormCaixaEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 505);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnNovaConta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbBuscaConta);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.Button btnRelatorios;
    }
}

