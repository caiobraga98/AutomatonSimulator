using System;

namespace AutomatonSimulator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Estado q0 = new Estado("q0");
            Estado q1 = new Estado("q1");
            Estado q2 = new Estado("q2");
            Estado q3 = new Estado("q3");
            Automato automato = new Automato();
            automato.AddEstadoStart(q0);
            automato.AddEstadoEnd(q2);
            // TESTE: Aceitar todo alfabeto que comece com B e termine com A
            q0.AdicionarTransicao(new Transicao("A", q3));
            q0.AdicionarTransicao(new Transicao("B", q1));
            q1.AdicionarTransicao(new Transicao("B", q1));
            q1.AdicionarTransicao(new Transicao("A", q2));
            q2.AdicionarTransicao(new Transicao("B", q1));
            q2.AdicionarTransicao(new Transicao("A", q2));
            automato.InserirLetrasAlfabeto("B");
            automato.InserirLetrasAlfabeto("A");
            automato.InserirLetrasAlfabeto("B");
            automato.InserirLetrasAlfabeto("A");
            automato.InserirLetrasAlfabeto("A");
            Console.WriteLine(automato.VerificarAutomatoAceito());
        }
    }
}