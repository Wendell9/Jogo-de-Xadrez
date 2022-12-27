using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linha, int coluna)
        {
            Linhas = linha;
            Colunas = coluna;
            this.pecas = new Peca[linha,coluna];
        }
    }
}
