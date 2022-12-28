using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using Xadrez;

namespace Jogo_de_Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Tabuleiro tab = new Tabuleiro(8,8);
            tab.colocaPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
            tab.colocaPeca(new Rei(tab, Cor.Preta), new Posicao(3, 6));
            Tela.imprimirTabuleiro(tab);
        }
    }
}
