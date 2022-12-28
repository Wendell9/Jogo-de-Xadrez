using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Xadrez
{
    internal class Partida_de_Xadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadoratual;
        public bool terminada { get; private set; }

        public Partida_de_Xadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadoratual = Cor.Branca;
            colocarPecas();
            terminada = false;
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarwteMovimentos();
            tab.retirarPeca(destino);
            Peca pecacapturada = tab.retirarPeca(destino);
            tab.colocaPeca(p, destino);
        }

        private void colocarPecas()
        {
            tab.colocaPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 1).toPosicao());
            tab.colocaPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 2).toPosicao());
            tab.colocaPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('d', 2).toPosicao());
            tab.colocaPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 2).toPosicao());
            tab.colocaPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 1).toPosicao());
            tab.colocaPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 1).toPosicao());
        }
    }
}
