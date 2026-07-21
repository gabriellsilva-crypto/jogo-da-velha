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
//adicionando cores
          Console.WriteLine();
        Console.WriteLine("Pressione ENTER para iniciar...");
        Console.ReadLine();


        Console.Clear();

        char[,] tabuleiro =
        {
            { '1', '2', '3' },
            { '4', '', '6' },
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

                Console.Write("Escolha uma posição (1-9): "); // atualizando posições

            if (!int.TryParse(Console.ReadLine(), out int posicao))
            {
    }
}
