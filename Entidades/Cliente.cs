using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico {
    public class Cliente {
        public string Nome { get; private set;}

        public Cliente(string nome) {
            Nome = nome;
        }
    }
}
