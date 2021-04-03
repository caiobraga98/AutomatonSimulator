using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AutomatonSimulator
{
    public class Estado
    {
        private string nomeEstado { get; set; }
        private List<Transicao> transicoes;

        public Estado(string nomeEstado)
        {
            this.nomeEstado = nomeEstado;
            List<Transicao> transicoes = new List<Transicao>();
        }

        public void adcionaTransicao(Transicao transicao)
        {
            transicoes.Add(transicao);
        }

        //public Estado VerificarTransicao(string letra)
        //{
        //    foreach (var transicao in transicoes)
        //    {
        //        if (letra == transicao.GetLetra())
        //        {
        //            return transicao.GetProximo();
        //        }
        //    }
        //    return ;
        //}
    }
}