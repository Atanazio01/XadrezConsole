using XadrezConsole.Tabuleiro.Enums;
namespace XadrezConsole.Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public TabuleiroClasse Tab { get; protected set; }

        public Peca()
        {
        }

        public Peca(Posicao posicao, Cor cor,TabuleiroClasse tab)
        {
            Posicao = posicao;
            Cor = cor;
            QteMovimentos = 0;
            Tab = tab;
        }
    }
}
