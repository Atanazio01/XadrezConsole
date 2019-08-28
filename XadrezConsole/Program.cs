using System;
using XadrezConsole.Tabuleiro.Enums;
using XadrezConsole.Tabuleiro;
using XadrezConsole.Xadrez;
using XadrezConsole.Tabuleiro.Exceptions;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                TabuleiroClasse tab = new TabuleiroClasse(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
