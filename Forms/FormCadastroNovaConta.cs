using CaixaEletronico.Contas;
using CaixaEletronico.Servicos;
using CaixaEletronico.Usuarios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CaixaEletronico {
    public partial class FormCadastroNovaConta : Form {

        private ICollection<string> devedores;

        private FormCaixaEletronico formPrincipal;

        public FormCadastroNovaConta(FormCaixaEletronico formPrincipal) {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores g = new GeradorDeDevedores();
            devedores = g.GerarListaNomes();
        }

        private void FormCadastroNovaConta_Load(object sender, EventArgs e)
        {
            txtNumero.Text = Conta.ProximoNumero().ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            if (ValidarCampos()) {
                if (!TitularEhDevedor(txtTitular.Text))
                {
                    if (comboTipoConta.Text == "Corrente")
                    {
                        Conta cc = new ContaCorrente(new Cliente(txtTitular.Text), 0);
                        this.formPrincipal.AdicionaNovaConta(cc);
                    }
                    else if (comboTipoConta.Text == "Poupança")
                    {
                        Conta cc = new ContaPoupanca(new Cliente(txtTitular.Text), 0);
                        this.formPrincipal.AdicionaNovaConta(cc);
                    }
                    else if (comboTipoConta.Text == "Estudante")
                    {
                        Conta cc = new ContaEstudante(new Cliente(txtTitular.Text), 0);
                        this.formPrincipal.AdicionaNovaConta(cc);
                    }
                    else if (comboTipoConta.Text == "Investimento")
                    {
                        Conta cc = new ContaInvestimento(new Cliente(txtTitular.Text), 0);
                        this.formPrincipal.AdicionaNovaConta(cc);
                    }
                    this.Close();
                }
            }
        }

        private bool ValidarCampos() {
            bool retornoValidacao = true;

            if (txtTitular.Text == "") {
                MessageBox.Show("Campos Vazios!");
                retornoValidacao = false;
            }
            else if (comboTipoConta.SelectedItem == null) {
                MessageBox.Show("Selecione um tipo de conta!");
                retornoValidacao = false;
            }
            
            return retornoValidacao;
        }

        private bool TitularEhDevedor(string titular)
        {
            bool ehDevedor = devedores.Contains(titular);

            if (ehDevedor)
            {
                MessageBox.Show("Titular é um devedor!");
            }

            return ehDevedor;
        }
    }
}
