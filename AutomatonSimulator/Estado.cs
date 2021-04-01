using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AutomatonSimulator
{
    public class Estado
    {
        public string nomeEstado { get; set; }
        private ArrayList transicoes;

        public Estado(string nomeEstado)
        {
            this.nomeEstado = nomeEstado;
            ArrayList transicoes = new ArrayList();
        }

        public void adcionaTransicao(Transicao transicao)
        {
            transicoes.Add(transicao);
        }
    }
}