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
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());
            Console.ReadLine();
        }
    }
}
