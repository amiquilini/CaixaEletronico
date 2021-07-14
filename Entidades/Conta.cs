using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
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
        public abstract bool Saca(double valor);
        public virtual bool Transfere(Conta contaDestino, double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                contaDestino.Deposita(valor);

                return true;
            }
            else
            {
                return false;
            }
        }

        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }
    }
}
