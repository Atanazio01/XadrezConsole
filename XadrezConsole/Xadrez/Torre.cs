using XadrezConsole.Tabuleiro.Enums;
using XadrezConsole.Tabuleiro;

namespace XadrezConsole.Xadrez
{
    class Torre : Peca
    {
        public Torre(TabuleiroClasse tab, Cor cor) : base(cor, tab)
        {
        }
        public override string ToString()
        {
            return "T";
        }
    }
}
