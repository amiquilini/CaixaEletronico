using CaixaEletronico.Excecoes;
using CaixaEletronico.Interfaces;
using CaixaEletronico.Usuarios;
using System;

namespace CaixaEletronico.Contas
{
    class ContaCorrente : Conta, ITributavel
    {

        public ContaCorrente(Cliente titular, double saldo) : base(titular, saldo)
        {

        }

        public double CalculaTributo()
        {
            return Saldo * 0.05;
        }

        public override void Deposita(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            Saldo += (valor - 0.10);
        }
        public override void Saca(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            else if (valor + 0.05 > Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= (valor + 0.05);
        }
    }
}
