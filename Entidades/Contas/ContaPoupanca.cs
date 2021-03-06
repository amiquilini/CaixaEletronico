using CaixaEletronico.Excecoes;
using CaixaEletronico.Interfaces;
using CaixaEletronico.Usuarios;
using System;

namespace CaixaEletronico.Contas
{
    class ContaPoupanca : Conta, ITributavel
    {

        public ContaPoupanca(Cliente titular, double saldo) : base(titular, saldo)
        {

        }

        public double CalculaTributo()
        {
            return Saldo * 0.02;
        }

        public override void Deposita(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            Saldo += valor;
        }

        public override void Saca(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            else if (valor + 0.10 > Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= (valor + 0.10);
        }
    }
}
