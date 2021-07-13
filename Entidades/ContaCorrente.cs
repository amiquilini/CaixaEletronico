using CaixaEletronico.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico {
    class ContaCorrente : Conta, ITributavel {

        public ContaCorrente(Cliente titular, int numero, double saldo) : base(titular, numero, saldo) {

        }

        public double CalculaTributo()
        {
            return Saldo * 0.05;
        }

        public override void Deposita(double valor)
        {
            if (valor > 0)
            {
                Saldo += (valor - 0.10);
            }
        }
        public override bool Saca(double valor)
        {
            if (valor + 0.05 > Saldo || valor == 0)
            {
                return false;
            }
            else
            {
                Saldo -= (valor + 0.05);
                return true;
            }
        }
    }
}
