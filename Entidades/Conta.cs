using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public abstract class Conta
    {
        public Cliente Titular { get; protected set; }
        public int Numero { get; protected set; }
        public double Saldo { get; protected set; }

        public Conta(Cliente titular, int numero, double saldo) {
            Titular = titular;
            Numero = numero;
            Saldo = saldo;
        }

        public abstract void Deposita(double valor);
        public abstract bool Saca(double valor);
        public virtual void Transfere(Conta contaDestino, double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                contaDestino.Deposita(valor);
            }
        }
    }
}
