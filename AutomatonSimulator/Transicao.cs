using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatonSimulator
{
    public class Transicao
    {
        private string letra { get; set; }
        private Estado proximo { get; set; }

        public Transicao(string letra, Estado proximo)
        {
            this.letra = letra;
            this.proximo = proximo;
        }

        public string GetLetra()
        {
            return letra;
        }

        public Estado GetProximo()
        {
            return proximo;
        }
    }
}