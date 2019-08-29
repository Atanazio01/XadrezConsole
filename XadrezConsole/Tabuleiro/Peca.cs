using XadrezConsole.Tabuleiro.Enums;
namespace XadrezConsole.Tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public TabuleiroClasse Tab { get; protected set; }

        public Peca()
        {
        }

        public Peca(Cor cor,TabuleiroClasse tab)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QteMovimentos = 0;
        }

        public abstract bool[,] MovimentosPossiveis();

    }
}
