using CaixaEletronico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        private List<Conta> contas = new List<Conta>();

        public Form1()
        {
            InitializeComponent();
        }

        public void AdicionaNovaConta(Conta conta)
        {
            contas.Add(conta);
            comboContas.Items.Add(conta.Titular.Nome);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Conta c1 = new ContaCorrente(new Cliente("Victor"), 100);
            Conta c2 = new ContaPoupanca(new Cliente("Mauricio"), 500);
            Conta c3 = new ContaEstudante(new Cliente("Osni"), 300);

            this.AdicionaNovaConta(c1);
            this.AdicionaNovaConta(c2);
            this.AdicionaNovaConta(c3);

            txtNumero.Enabled = false;
            txtSaldo.Enabled = false;
            txtTitular.Enabled = false;
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (ValidaConta() && ValidaValor())
            {
                int indice = comboContas.SelectedIndex;
                double valor = double.Parse(txtValor.Text);
                try
                {
                    contas[indice].Deposita(valor);

                    txtSaldo.Text = contas[indice].Saldo.ToString("C");

                    MessageBox.Show("Depósito realizado com sucesso!");
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
                int indice = comboContas.SelectedIndex;
                double valor = double.Parse(txtValor.Text);

                try
                {
                    contas[indice].Saca(valor);
                    txtSaldo.Text = contas[indice].Saldo.ToString("C");

                    MessageBox.Show("Dinheiro liberado!");
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
                int indice1 = comboContas.SelectedIndex;
                int indice2 = comboDestinoTransferencia.SelectedIndex;
                double valor = double.Parse(txtValor.Text);

                if (indice1 != indice2)
                {
                    try
                    {
                        contas[indice1].Transfere(contas[indice2], valor);
                        txtSaldo.Text = contas[indice1].Saldo.ToString("C");

                        MessageBox.Show("Tranferência realizada com sucesso!");
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
                else
                {
                    MessageBox.Show("Operação inválida.");
                }
            }
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

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            comboDestinoTransferencia.Items.Clear();

            txtTitular.Text = contas[indice].Titular.Nome;
            txtNumero.Text = contas[indice].Numero.ToString();
            txtSaldo.Text = contas[indice].Saldo.ToString("C");

            foreach (Conta conta in contas)
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
                t.Adiciona(conta);
            }

            MessageBox.Show("Saldo total em caixa: " + t.SaldoTotal.ToString("C"));
        }

        private void btnCalcularTributos_Click(object sender, EventArgs e)
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

        private void btnImposto_Click(object sender, EventArgs e)
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
    }
}
