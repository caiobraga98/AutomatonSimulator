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
            q1.AdicionarTransicao(t);
            Automato automato = new Automato();
            automato.AddEstadoStart(q1);
            automato.AddEstadoEnd(q2);
            automato.InserirLetrasAlfabeto("A");
            automato.VerificarAutomatoAceito();
        }
    }
}