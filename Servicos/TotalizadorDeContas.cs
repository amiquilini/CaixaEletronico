using CaixaEletronico.Contas;

namespace CaixaEletronico.Servicos
{
    class TotalizadorDeContas
    {
        public double SaldoTotal { get; private set; }
        public void Adiciona(Conta conta) {
            SaldoTotal += conta.Saldo;
        }
    }
}
