using CaixaEletronico.Contas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaixaEletronico.Forms
{
    public partial class FormRelatorios : Form
    {
        private FormCaixaEletronico formPrincipal;
        private List<Conta> contas;

        public FormRelatorios(List<Conta> contas)
        {
            this.contas = contas;
            InitializeComponent();
        }

        private void FormRelatorios_Load(object sender, EventArgs e)
        {
        }

        private void btnFiltroContas_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            var contasFiltradas = (IEnumerable) contas;

            if (ValidaValor() && ValidaNumeroConta())
            {
                if (txtValor.Text != "" && txtNumeroConta.Text != "")
                {
                    double valor = Convert.ToDouble(txtValor.Text);
                    int num = Convert.ToInt32(txtNumeroConta.Text);

                    contasFiltradas = contas.Where(c => (c.Saldo > valor) && (c.Numero < num));
                }
                else if (txtValor.Text != "")
                {
                    double valor = Convert.ToDouble(txtValor.Text);

                    contasFiltradas = contas.Where(c => c.Saldo > valor);
                }
                else if (txtNumeroConta.Text != "")
                {
                    int num = Convert.ToInt32(txtNumeroConta.Text);

                    contasFiltradas = contas.Where(c => c.Numero < num);
                }

                foreach (var c in contasFiltradas)
                {
                    lstResultado.Items.Add(c);
                }
            }
            
        }

        private bool ValidaValor()
        {
            bool retornoValidacao = true;
            if (txtValor.Text != "" && !double.TryParse(txtValor.Text, out double valor))
            {
                MessageBox.Show("Digite um valor válido.");
                retornoValidacao = false;
            }

            return retornoValidacao;
        }

        private bool ValidaNumeroConta()
        {
            bool retornoValidacao = true;
            if (txtNumeroConta.Text != "" && !int.TryParse(txtNumeroConta.Text, out int numeroConta))
            {
                MessageBox.Show("Digite um valor válido.");
                retornoValidacao = false;
            }

            return retornoValidacao;
        }
    }
}
