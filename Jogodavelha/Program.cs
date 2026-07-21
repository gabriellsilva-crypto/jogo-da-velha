//primeira etapa
using System;
class Program 
  {
    static void Main(string[] args)
     {
        Console.Title = "Jogo da Velha";

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=======================");
        Console.WriteLine("         JOGO DA VELHA");
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
     MostrarTabuleiro(tabuleiro);
    }

    static void MostrarTabuleiro(char[,] tabuleiro)
    {
        Console.WriteLine();

        Console.WriteLine($" {tabuleiro[0, 0]} | {tabuleiro[0, 1]} | {tabuleiro[0, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {tabuleiro[1, 0]} | {tabuleiro[1, 1]} | {tabuleiro[1, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {tabuleiro[2, 0]} | {tabuleiro[2, 1]} | {tabuleiro[2, 2]} ");

        Console.WriteLine();
    }
}
