using XadrezConsole.Tabuleiro.Enums;
using XadrezConsole.Tabuleiro;

namespace XadrezConsole.Xadrez
{
    class Rei : Peca
    {
        public Rei(TabuleiroClasse tab, Cor cor) : base(cor, tab)
        {
        }
        public override string ToString()
        {
            return "R";
        }
    }
}
