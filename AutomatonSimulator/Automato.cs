using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AutomatonSimulator
{
    public class Automato
    {
        private ArrayList alfabeto;
        private ArrayList estados;
        public Estado estadoinicial { get; set; }
        public Estado estadoFinal { get; set; }

        public Automato()
        {
        }

        public void addEstadoInicial(Estado estado)
        {
            estadoinicial = estado;
        }

        public void addEstado(Estado estado)
        {
            estados.Add(estado);
        }

        public void addEstadoFinal(Estado estado)
        {
            estadoFinal = estado;
        }

        public void inserirLetrasAlfabeto(string letra)
        {
            alfabeto.Add(letra);
        }

        //Metodos internos

        //verifica se existe uma letra no alfabeto
        //caso não exista,retorna -1
        private bool procurarLetraAlfabeto(String letra)
        {
            if (alfabeto.IndexOf(letra) == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}