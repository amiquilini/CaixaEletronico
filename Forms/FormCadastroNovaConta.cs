using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaixaEletronico {
    public partial class FormCadastroNovaConta : Form {
        private Form1 formPrincipal;
        public FormCadastroNovaConta(Form1 formPrincipal) {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            if (ValidarCampos()) {
                if(comboTipoConta.Text == "Corrente") {
                    Conta cc = new ContaCorrente(new Cliente(txtTitular.Text), Convert.ToInt32(txtNumero.Text), 0);
                    this.formPrincipal.AdicionaNovaConta(cc);
                }
                else if (comboTipoConta.Text == "Poupança") {
                    Conta cc = new ContaPoupanca(new Cliente(txtTitular.Text), Convert.ToInt32(txtNumero.Text), 0);
                    this.formPrincipal.AdicionaNovaConta(cc);
                }
                else if (comboTipoConta.Text == "Estudante") {
                    Conta cc = new ContaEstudante(new Cliente(txtTitular.Text), Convert.ToInt32(txtNumero.Text), 0);
                    this.formPrincipal.AdicionaNovaConta(cc);
                }
                else if (comboTipoConta.Text == "Investimento")
                {
                    Conta cc = new ContaInvestimento(new Cliente(txtTitular.Text), Convert.ToInt32(txtNumero.Text), 0);
                    this.formPrincipal.AdicionaNovaConta(cc);
                }
                this.Close();
            }
        }

        private bool ValidarCampos() {
            bool retornoValidacao = true;

            if (txtNumero.Text == string.Empty || txtTitular.Text == "") {
                MessageBox.Show("Campos Vazios!");
                retornoValidacao = false;
            }
            else if (comboTipoConta.SelectedItem == null) {
                MessageBox.Show("Selecione um tipo de conta!");
                retornoValidacao = false;
            }
            return retornoValidacao;
        }

        private void FormCadastroNovaConta_Load(object sender, EventArgs e) {

        }
    }
}
