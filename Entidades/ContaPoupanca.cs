using CaixaEletronico.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico {
    class ContaPoupanca : Conta, ITributavel {

        public ContaPoupanca(Cliente titular, double saldo) : base(titular, saldo) { 
         
        }

        public double CalculaTributo()
        {
            return Saldo * 0.02;
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
            if (valor + 0.10 > Saldo || valor == 0)
            {
                return false;
            }
            else
            {
                Saldo -= (valor + 0.10);
                return true;
            }
        }
    }
}
