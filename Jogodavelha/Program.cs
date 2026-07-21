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