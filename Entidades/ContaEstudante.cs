using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    class ContaEstudante : Conta
    {

        public ContaEstudante(Cliente titular, double saldo) : base(titular, saldo)
        {

        }
        public override void Deposita(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            Saldo += valor * 1.10;
        }

        public override void Saca(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            else if (valor > Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= valor;
        }
    }
}
