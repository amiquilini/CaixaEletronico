using CaixaEletronico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        private Conta[] contas = new Conta[10];
        private int numeroDeContas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void AdicionaNovaConta(Conta conta)
        {
            this.contas[this.numeroDeContas++] = conta;
            comboContas.Items.Add(conta.Titular.Nome);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Conta c1 = new ContaCorrente(new Cliente("Victor"), 1, 100);
            Conta c2 = new ContaPoupanca(new Cliente("Mauricio"), 2, 500);
            Conta c3 = new ContaEstudante(new Cliente("Osni"), 3, 300);

            this.AdicionaNovaConta(c1);
            this.AdicionaNovaConta(c2);
            this.AdicionaNovaConta(c3);

            txtNumero.Enabled = false;
            txtSaldo.Enabled = false;
            txtTitular.Enabled = false;
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (ValidaContaEValor())
            {
                int indice = comboContas.SelectedIndex;

                double valor = double.Parse(txtValor.Text);
                contas[indice].Deposita(valor);

                txtSaldo.Text = contas[indice].Saldo.ToString("C");
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (ValidaContaEValor())
            {
                int indice = comboContas.SelectedIndex;

                double valor = double.Parse(txtValor.Text);
                bool operacaoSaca = contas[indice].Saca(valor);

                if (!operacaoSaca)
                {
                    MessageBox.Show("Saldo insuficiente!");
                }

                txtSaldo.Text = contas[indice].Saldo.ToString("C");
            }
        }

        private bool ValidaContaEValor()
        {
            bool retornoValidacao = true;
            if (comboContas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma conta!");
                retornoValidacao = false;
            }
            else if (txtValor.Text == string.Empty || txtValor.Text.All(char.IsLetter))
            {
                MessageBox.Show("Valor inválido.");
                retornoValidacao = false;
            }
            return retornoValidacao;
        }

        private bool ValidaDestinoTransferencia()
        {
            bool retornoValidacao = true;
            if (comboDestinoTransferencia.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma conta destino!");
                retornoValidacao = false;
            }
            return retornoValidacao;
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            comboDestinoTransferencia.Items.Clear();

            txtTitular.Text = contas[indice].Titular.Nome;
            txtNumero.Text = contas[indice].Numero.ToString();
            txtSaldo.Text = contas[indice].Saldo.ToString("C");

            foreach (Conta conta in contas)
            {
                if (conta != null)
                {
                    if (conta.Titular.Nome == contas[indice].Titular.Nome)
                    {
                        comboDestinoTransferencia.Items.Add(conta.Titular.Nome + " - você");
                    }
                    else
                    {
                        comboDestinoTransferencia.Items.Add(conta.Titular.Nome);
                    }
                }
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (ValidaContaEValor() && ValidaDestinoTransferencia())
            {
                int indice1 = comboContas.SelectedIndex;
                int indice2 = comboDestinoTransferencia.SelectedIndex;
                double valor = double.Parse(txtValor.Text);

                if (indice1 != indice2)
                {
                    contas[indice1].Transfere(contas[indice2], valor);
                }
                else
                {
                    MessageBox.Show("Operação inválida.");
                }
            }
        }

        private void comboDestinoTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroNovaConta frmCadastro = new FormCadastroNovaConta(this);
            frmCadastro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TotalizadorDeContas t = new TotalizadorDeContas();

            foreach (var conta in contas)
            {
                if (conta != null) t.Adiciona(conta);
            }

            MessageBox.Show("Saldo Total: " + t.SaldoTotal.ToString("C"));
        }

        private void btnCalcularTributos_Click(object sender, EventArgs e)
        {
            TotalizadorDeTributos t = new TotalizadorDeTributos();

            foreach (var conta in contas)
            {
                if (conta != null && conta is ITributavel)
                {
                    t.Acumula((ITributavel)conta);
                }
            }

            MessageBox.Show("Imposto Total: " + t.Total.ToString("C"));
        }
    }
}
