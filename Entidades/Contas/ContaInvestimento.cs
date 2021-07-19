using CaixaEletronico.Excecoes;
using CaixaEletronico.Interfaces;
using CaixaEletronico.Usuarios;
using System;

namespace CaixaEletronico.Contas
{
    class ContaInvestimento : Conta, ITributavel
    {

        public ContaInvestimento(Cliente titular, double saldo) : base(titular, saldo)
        {

        }

        public double CalculaTributo()
        {
            return Saldo * 0.03;
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
            else if (valor > Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= valor;
        }
    }
}
