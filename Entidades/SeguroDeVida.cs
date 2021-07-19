using CaixaEletronico.Interfaces;

namespace CaixaEletronico
{
    class SeguroDeVida : ITributavel
    {
        public double CalculaTributo()
        {
            return 42.0;
        }
    }
}
