using System;

class Program
{

    static void Main(string[] args)
    {
        Console.Title = "Jogo da Velha";

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=======================");
        Console.WriteLine("      JOGO DA VELHA");
        Console.WriteLine("=======================");
        Console.ResetColor();

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para iniciar...");
        Console.ReadLine();

        Console.Clear();

        char[,] tabuleiro =
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        char jogador = 'X';

        while (true)
        {
            Console.Clear();
            MostrarTabuleiro(tabuleiro);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nVez do jogador {jogador}");
            Console.ResetColor();

            break; // apenas para esta primeira etapa
        }
    }

    static void MostrarTabuleiro(char[,] tabuleiro)
    {
        Console.WriteLine();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($" {tabuleiro[i,0]} | {tabuleiro[i,1]} | {tabuleiro[i,2]} ");

            if (i < 2)
                Console.WriteLine("---+---+---");
        }
    }
}