﻿using CaixaEletronico.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    class TotalizadorDeTributos
    {
        public double Total { get; set; }

        public void Acumula(ITributavel contaTributavel)
        {
            Total += contaTributavel.CalculaTributo();
        }
    }
}
