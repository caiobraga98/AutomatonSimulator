using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatonSimulator
{
    public class Estado
    {
        public string nomeEstado { get; set; }
        public bool IsEnd { get; set; }

        public Estado(string nomeEstado, bool isEnd)
        {
            this.nomeEstado = nomeEstado;
            IsEnd = isEnd;
        }
    }
}