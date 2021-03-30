using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatonSimulator
{
    internal class Automato
    {
        public int qtdEstados { get; set; }

        public string[][] Estados { get; set; }

        public Automato(int qtdestados)
        {
            this.qtdEstados = qtdestados;
        }
    }
}