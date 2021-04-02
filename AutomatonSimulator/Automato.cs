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
            estados.Add(estado);
        }

        public void addEstado(Estado estado)
        {
            estados.Add(estado);
        }
    }
}