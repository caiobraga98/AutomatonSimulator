using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AutomatonSimulator
{
    public class Automato
    {
        private List<string> Palavra { get; set; }
        private List<string> LetrasAlfabeto { get; set; }
        private Estado EstadoInicial { get; set; }
        private Estado EstadoFinal { get; set; }

        private Estado EstadoAtual { get; set; }

        public Automato()
        {
            Palavra = new List<string>();
            LetrasAlfabeto = new List<string>();
        }

        public void InserirEstadoInicial(Estado estado)
        {
            EstadoInicial = estado;
        }

        public void InserirEstadoFinal(Estado estado)
        {
            EstadoFinal = estado;
        }

        public void InserirLetraPalavra(string letra)
        {
            Palavra.Add(letra);
        }

        public void InserirLetraAlfabeto(string letra)
        {
            LetrasAlfabeto.Add(letra);
        }

        public bool VerificarPalavraAceita()
        {
            if (!VerificarPalavraAlfabeto())
            {
                ConverterDeterministico();
                Console.WriteLine("Automato nao deterministico transformado em deterministico!");
            }

            EstadoAtual = EstadoInicial;
            foreach (var letra in Palavra)
            {
                EstadoAtual = EstadoAtual.VerificarTransicao(letra, EstadoAtual);
            }

            if (EstadoAtual == EstadoFinal)
                return true;
            else
                return false;
        }

        public bool VerificarPalavraAlfabeto()
        {
            foreach (var letra in Palavra)
            {
                if (!LetrasAlfabeto.Contains(letra))
                {
                    return false;
                }
            }
            return true;
        }

        public void ConverterDeterministico()
        {
            foreach (var letra in new List<string>(Palavra))
            {
                if (!LetrasAlfabeto.Contains(letra))
                {
                    Palavra.Remove(letra);
                }
            }
        }
    }
}