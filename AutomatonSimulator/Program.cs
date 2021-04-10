using System;

namespace AutomatonSimulator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Estado q0 = new Estado("q0");
            Estado q1 = new Estado("q1");
            Estado q2 = new Estado("q2");
            Estado q3 = new Estado("q3");
            Automato automato = new Automato();
            automato.InserirLetraAlfabeto("A");
            automato.InserirLetraAlfabeto("B");
            automato.InserirEstadoInicial(q0);
            automato.InserirEstadoFinal(q2);
            // TESTE: Aceitar todo alfabeto que comece com B e termine com A
            q0.AdicionarTransicao(new Transicao("A", q3));
            q0.AdicionarTransicao(new Transicao("B", q1));
            q1.AdicionarTransicao(new Transicao("B", q1));
            q1.AdicionarTransicao(new Transicao("A", q2));
            q2.AdicionarTransicao(new Transicao("B", q1));
            q2.AdicionarTransicao(new Transicao("A", q2));
            automato.InserirLetraPalavra("B");
            automato.InserirLetraPalavra("B");
            automato.InserirLetraPalavra("A");
            automato.InserirLetraPalavra("B");
            automato.InserirLetraPalavra("A");
            //Console.WriteLine(automato.VerificarPalavraAlfabeto());
            Console.WriteLine(automato.VerificarPalavraAceita());
        }
    }
}