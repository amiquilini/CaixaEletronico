using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Servicos
{
    class GeradorDeDevedores
    {
        public HashSet<string> GerarListaNomes()
        {
            var nomes = new HashSet<string>();

            for (int i = 0; i < 1000; i++)
            {
                nomes.Add("Devedor " + i);
            }
            return nomes;
        }
    }
}
