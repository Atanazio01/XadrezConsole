using System;
using XadrezConsole.Tabuleiro;
namespace XadrezConsole
{
    class Tela
    {
        public static void imprimirTabuleiro(TabuleiroClasse tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.PecaTab(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.PecaTab(i, j) + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
