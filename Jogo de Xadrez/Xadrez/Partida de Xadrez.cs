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
        public int turno;
        public Cor jogadoratual { get; private set; }
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

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        public void validarPosicaoDeOrigem(Posicao pos)
        {
            if (tab.peca(pos)==null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida!");
            }
            if (jogadoratual != tab.peca(pos).cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é a sua!");
            }
            if (!tab.peca(pos).existeMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possiveis para a peça de origem escolhida!");
            }
        }

        public void validarPoscaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!tab.peca(origem).podeMoverPara(destino))
            {
                throw new TabuleiroException("Poisção de destino inválida!");
            }
        }

        public void mudaJogador()
        {
            if (jogadoratual==Cor.Branca)
            {
                jogadoratual = Cor.Preta;
            }
            else
            {
                jogadoratual = Cor.Branca;
            }
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
