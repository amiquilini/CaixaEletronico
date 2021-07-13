using CaixaEletronico.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
