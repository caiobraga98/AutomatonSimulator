using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AutomatonSimulator
{
    public class Estado
    {
        private string NomeEstado { get; set; }
        private List<Transicao> Transicoes { get; set; }

        public Estado(string nomeEstado)
        {
            NomeEstado = nomeEstado;
            Transicoes = new List<Transicao>();
        }

        public void AdicionarTransicao(Transicao transicao)
        {
            Transicoes.Add(transicao);
        }

        public Estado VerificarTransicao(string letra, Estado EstadoAtual)
        {
            foreach (var transicao in Transicoes)
            {
                if (letra == transicao.GetLetra())
                {
                    return transicao.GetProximo();
                }
            }

            return EstadoAtual;
        }
    }
}