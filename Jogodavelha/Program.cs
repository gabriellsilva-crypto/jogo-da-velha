
    //primeira etapa
    using System;
    class Program
    {
        static string caixa = @"
╔══════════════════════════════════════════╗
║                                          ║
║                                          ║
║                                          ║
║                                          ║
║                                          ║
║                                          ║
║                                          ║
║                                          ║
║                                          ║
║                                          ║
║                                          ║
║                                          ║
╚══════════════════════════════════════════╝
";
        static void Main(string[] args)
        {
            
            Console.Title = "Jogo da Velha";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(caixa);
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=======================");
            Console.WriteLine("     JOGO DA VELHA     ");
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
                { '4', '5', '6' },
                { '7', '8', '9' }
            };

            char jogador = 'X';
            int jogadas = 0;

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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Digite apenas números!");
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }

                if (posicao < 1 || posicao > 9)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Escolha um número entre 1 e 9!");
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }

                // COLOQUE AQUI
                int linha = (posicao - 1) / 3;
                int coluna = (posicao - 1) % 3;

                // Verifica se a posição já está ocupada
                if (tabuleiro[linha, coluna] == 'X' || tabuleiro[linha, coluna] == 'O')
                
                {
                    Console.WriteLine("Essa posição já está ocupada!");
                    Console.ReadKey();
                    continue;
                }

                // Marca a jogada
                tabuleiro[linha, coluna] = jogador;
                jogadas++;
                // Troca o jogador
                jogador = (jogador == 'X') ? 'O' : 'X';
            }
        }
        static void MostrarTabuleiro(char[,] tabuleiro)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($" {tabuleiro[i, 0]} | {tabuleiro[i, 1]} | {tabuleiro[i, 2]}");

                if (i < 2)
                    Console.WriteLine("---+---+---");
            }
        }
    }


