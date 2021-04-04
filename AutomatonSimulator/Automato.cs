using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AutomatonSimulator
{
    public class Automato
    {
        private List<string> Alfabeto { get; set; }
        private Estado EstadoStart { get; set; }
        private Estado EstadoEnd { get; set; }

        private Estado EstadoAtual { get; set; } 

        public Automato()
        {
            Alfabeto = new List<string>();
        }

        public void AddEstadoStart(Estado estado)
        {
            EstadoStart = estado;
        }

        public void AddEstadoEnd(Estado estado)
        {
            EstadoEnd = estado;
        }

        public void InserirLetrasAlfabeto(string letra)
        {
            Alfabeto.Add(letra);
        }

        public bool VerificarAutomatoAceito()
        {
            EstadoAtual = EstadoStart;
            foreach (var letra in Alfabeto)
            {
                EstadoAtual = EstadoAtual.VerificarTransicao(letra, EstadoAtual);
            }

            if (EstadoAtual == EstadoEnd)
                return true;
            else
                return false;
        }

        //private bool ProcurarLetraAlfabeto(string letra)
        //{
        //    if (Alfabeto.IndexOf(letra) == -1)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
    }
}