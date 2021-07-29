﻿using CaixaEletronico.Interfaces;
using CaixaEletronico.Contas;
using CaixaEletronico.Usuarios;
using CaixaEletronico.Excecoes;
using CaixaEletronico.Servicos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class FormCaixaEletronico : Form
    {
        private List<Conta> contas;
        private Dictionary<string, Conta> dicionario;

        public FormCaixaEletronico()
        {
            InitializeComponent();
        }
        private void FormCaixaEletronico_Load(object sender, EventArgs e)
        {
            contas = new List<Conta>();
            dicionario = new Dictionary<string, Conta>();

            Conta c1 = new ContaCorrente(new Cliente("Amanda"), 500);
            Conta c2 = new ContaPoupanca(new Cliente("Camila"), 500);
            Conta c3 = new ContaEstudante(new Cliente("Rafael"), 500);

            this.AdicionaNovaConta(c1);
            this.AdicionaNovaConta(c2);
            this.AdicionaNovaConta(c3);

            txtNumero.Enabled = false;
            txtSaldo.Enabled = false;
            txtTitular.Enabled = false;
        }
        public void AdicionaNovaConta(Conta conta)
        {
            contas.Add(conta);
            dicionario.Add(conta.Titular.Nome, conta);
            comboContas.Items.Add(conta);
            comboContas.DisplayMember = "Titular";
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (ValidaConta() && ValidaValor())
            {
                Conta conta = (Conta)comboContas.SelectedItem;
                double valor = double.Parse(txtValor.Text);

                try
                {
                    conta.Deposita(valor);

                    txtSaldo.Text = conta.Saldo.ToString("C");

                    MessageBox.Show("Depósito realizado com sucesso!");

                    txtValor.Text = "";
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Não é possível depositar um valor negativo.");
                }
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (ValidaConta() && ValidaValor())
            {
                Conta conta = (Conta)comboContas.SelectedItem;
                double valor = double.Parse(txtValor.Text);

                try
                {
                    conta.Saca(valor);
                    txtSaldo.Text = conta.Saldo.ToString("C");

                    MessageBox.Show("Dinheiro liberado!");

                    txtValor.Text = "";
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Não é possível sacar um valor negativo.");
                }
                catch (SaldoInsuficienteException)
                {
                    MessageBox.Show("Saldo Insuficiente.");
                }
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (ValidaConta() && ValidaValor() && ValidaDestinoTransferencia())
            {
                Conta conta1 = (Conta)comboContas.SelectedItem;
                Conta conta2 = (Conta)comboDestinoTransferencia.SelectedItem;

                double valor = double.Parse(txtValor.Text);

                try
                {
                    conta1.Transfere(conta2, valor);
                    txtSaldo.Text = conta1.Saldo.ToString("C");

                    MessageBox.Show("Tranferência realizada com sucesso!");

                    txtValor.Text = "";
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Não é possível transferir um valor negativo.");
                }
                catch (SaldoInsuficienteException)
                {
                    MessageBox.Show("Saldo Insuficiente.");
                }
            }
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValor.Text = "";

            Conta conta = (Conta)comboContas.SelectedItem;

            PreencherInformacoes(conta);
        }

        private void btnBuscaConta_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeTitular = txtBuscaTitular.Text;

                Conta conta = dicionario[nomeTitular];

                txtValor.Text = "";

                comboContas.SelectedItem = conta;

                PreencherInformacoes(conta);
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Titular não encontrado!");
            }
        }
        private void PreencherInformacoes(Conta conta)
        {
            comboDestinoTransferencia.Items.Clear();

            txtTitular.Text = conta.Titular.Nome;
            txtNumero.Text = conta.Numero.ToString();
            txtSaldo.Text = conta.Saldo.ToString("C");

            foreach (Conta outra in contas)
            {
                if (outra.Numero != conta.Numero)
                {
                    comboDestinoTransferencia.Items.Add(outra);
                    comboDestinoTransferencia.DisplayMember = "Titular";
                }
            }
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroNovaConta frmCadastro = new FormCadastroNovaConta(this);
            frmCadastro.ShowDialog();
        }

        private void btnTotalizarContas_Click(object sender, EventArgs e)
        {
            TotalizadorDeContas t = new TotalizadorDeContas();

            foreach (var conta in contas)
            {
                t.Adiciona(conta);
            }

            MessageBox.Show("Saldo total em caixa: " + t.SaldoTotal.ToString("C"));
        }

        private void btnCalcularTributo_Click(object sender, EventArgs e)
        {
            if (ValidaConta())
            {
                int indice = comboContas.SelectedIndex;

                if (contas[indice] is ITributavel)
                {

                    double valor = contas[indice].Saldo;
                    ITributavel contaSelecionada = (ITributavel)contas[indice];

                    MessageBox.Show("Imposto a ser recolhido: " + contaSelecionada.CalculaTributo().ToString("C"));
                }
                else
                {
                    MessageBox.Show("Não há tributos para seu tipo de conta.");
                }
            }
        }
        private void btnTotalizarTributos_Click(object sender, EventArgs e)
        {
            TotalizadorDeTributos t = new TotalizadorDeTributos();

            foreach (var conta in contas)
            {
                if (conta is ContaCorrente)
                {
                    t.Acumula((ContaCorrente)conta);
                }
            }

            MessageBox.Show("Imposto total a ser recolhido de correntistas: " + t.Total.ToString("C"));
        }
        private bool ValidaConta()
        {
            bool retornoValidacao = true;
            if (comboContas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma conta!");
                retornoValidacao = false;
            }

            return retornoValidacao;
        }

        private bool ValidaValor()
        {
            bool retornoValidacao = true;
            if (!double.TryParse(txtValor.Text, out double valor) || txtValor.Text == "0")
            {
                MessageBox.Show("Digite um valor válido.");
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

        private void comboDestinoTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
