using tabuleiro;
using xadrez_console;

internal class Program {
    private static void Main(string[] args) {
        Posicao P;

        Tabuleiro tab = new Tabuleiro(8, 8);

        Tela.imprimirTabuleiro(tab);

        Console.ReadLine();
    }
}