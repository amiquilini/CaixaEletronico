using CaixaEletronico.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico {
    class ContaInvestimento : Conta, ITributavel {

        public ContaInvestimento(Cliente titular, int numero, double saldo) : base(titular, numero, saldo) {

        }

        public double CalculaTributo()
        {
            return Saldo * 0.03;
        }

        public override void Deposita(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }
        public override bool Saca(double valor)
        {
            if (valor > Saldo || valor == 0)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                return true;
            }
        }
    }
}
