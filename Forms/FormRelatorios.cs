using CaixaEletronico.Contas;
using System;
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

        private void btnFiltroSaldo_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();

            if (ValidaValor())
            {
                double valor = Convert.ToDouble(txtValor.Text);

                var contasFiltradas = contas.Where(c => c.Saldo > valor);

                foreach (var c in contasFiltradas)
                {
                    lstResultado.Items.Add(c);
                }
            }
            
        }

        private bool ValidaValor()
        {
            bool retornoValidacao = true;
            if (!double.TryParse(txtValor.Text, out double valor))
            {
                MessageBox.Show("Digite um valor válido.");
                retornoValidacao = false;
            }

            return retornoValidacao;
        }
    }
}
