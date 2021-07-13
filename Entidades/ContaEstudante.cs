using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico {
    class ContaEstudante : Conta {

        public ContaEstudante(Cliente titular, int numero, double saldo) : base(titular, numero, saldo) {

        }
        public override void Deposita(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor*1.10;
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
                Saldo -= (valor);
                return true;
            }
        }
    }
}
