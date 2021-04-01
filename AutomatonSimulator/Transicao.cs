using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatonSimulator
{
    public class Transicao
    {
        public string letra { get; set; }
        public Estado proximo { get; set; }

        public Transicao(string letra, Estado proximo)
        {
            this.letra = letra;
            this.proximo = proximo;
        }
    }
}