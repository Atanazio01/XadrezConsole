using XadrezConsole.Tabuleiro.Enums;
namespace XadrezConsole.Tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public TabuleiroClasse tab { get; protected set; }

        public Peca()
        {
        }

        public Peca(Posicao posicao, Cor cor,TabuleiroClasse tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.qteMovimentos = 0;
            this.tab = tab;
        }
    }
}
