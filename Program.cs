using System;
using xadrez;
using tabuleiro;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 4));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(7, 6));
                Tela.imprimirTabuleiro(tab);
            }
            catch(TabuleiroException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
