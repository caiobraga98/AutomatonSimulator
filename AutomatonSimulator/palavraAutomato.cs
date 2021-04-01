using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatonSimulator
{
    internal class palavraAutomato
    {
        private string[] Letras;
        private int qtdLetras { get; set; }

        public palavraAutomato(int qtdletras)
        {
            this.qtdLetras = qtdLetras;
        }

        public void inserirPalavra()
        {
            while (this.qtdLetras > 0)
            {
                Console.WriteLine("Inserir a palavra letra a letra");
                this.Letras[qtdLetras] = Console.ReadLine();
                this.qtdLetras--;
            }
            //inverter matriz
            int i = 0;
            int j = Letras.Length - 1;
            while (i < j)
            {
                var temp = Letras[i];
                Letras[i] = Letras[j];
                Letras[j] = temp;
                i++;
                j--;
            }
        }

        public void mostrarPalaVra()
        {
            foreach (string letra in Letras)
            {
                Console.WriteLine("..........");
                Console.WriteLine(letra);
            }
        }
    }
}