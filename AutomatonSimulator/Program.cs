using System;

namespace AutomatonSimulator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Estado q1 = new Estado("q1");
            Estado q2 = new Estado("q2");
            Transicao t = new Transicao("A", q2);
            q1.adcionaTransicao(t);
            Automato automato = new Automato();
            automato.addEstado(q1);
            automato.addEstado(q2);
            automato.addEstadoInicial(q1);
            automato.addEstadoFinal(q2);
            automato.inserirLetrasAlfabeto("A");
        }
    }
}