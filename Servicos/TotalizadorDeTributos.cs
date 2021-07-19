using CaixaEletronico.Interfaces;

namespace CaixaEletronico.Servicos
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumula(ITributavel contaTributavel)
        {
            Total += contaTributavel.CalculaTributo();
        }
    }
}
