using CaixaEletronico.Excecoes;
using CaixaEletronico.Usuarios;
using System;

namespace CaixaEletronico.Contas
{
    public abstract class Conta
    {
        public static int numeroDeContas { get; protected set; }
        public Cliente Titular { get; protected set; }
        public int Numero { get; protected set; }
        public double Saldo { get; protected set; }

        public Conta(Cliente titular, double saldo) {
            Titular = titular;
            Saldo = saldo;
            Numero = ++numeroDeContas;
        }

        public abstract void Deposita(double valor);
        public abstract void Saca(double valor);
        public void Transfere(Conta contaDestino, double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            else if (valor > Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                Saldo -= valor;
                contaDestino.Saldo += valor;
            } 
        }

        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }
    }
}
