using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatonSimulator
{
    public class Transicao
    {
        private string Letra { get; set; }
        private Estado Proximo { get; set; }

        public Transicao(string letra, Estado proximo)
        {
            Letra = letra;
            Proximo = proximo;
        }

        public string GetLetra()
        {
            return Letra;
        }

        public Estado GetProximo()
        {
            return Proximo;
        }
    }
}