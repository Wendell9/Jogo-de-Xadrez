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
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocaPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocaPeca(new Rei(tab, Cor.Preta), new Posicao(1, 9));
                tab.colocaPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocaPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
