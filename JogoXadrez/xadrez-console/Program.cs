using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Tabuleiro tab = new Tabuleiro(8, 8);
            //    tab.colocaPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //    tab.colocaPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            //    tab.colocaPeca(new Rei(tab, Cor.Preta), new Posicao(1, 89));

            //    Tela.imprimirTabuleiro(tab);

            //    Console.WriteLine();

            //    Console.ReadKey();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadKey();

        }
    }
}
