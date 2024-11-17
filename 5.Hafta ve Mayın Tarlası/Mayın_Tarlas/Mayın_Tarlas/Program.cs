using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayın_Tarlas
{
    class Program
    {
        const int boardSize = 20;
        const int mineCount = 40;
        static char[,] board = new char[boardSize, boardSize];
        static bool[,] revealed = new bool[boardSize, boardSize];
        static Random random = new Random();

        static void Main(string[] args)
        {
            InitializeBoard();
            PlaceMines();
            PlayGame();
            Console.ReadKey();
        }

        static void InitializeBoard()
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    board[i, j] = '0'; // Başlangıçta her hücre boş
                    revealed[i, j] = false; // Hiçbir hücre açılmamış durumda
                }
            }
        }

        static void PlaceMines()
        {
            int placedMines = 0;
            while (placedMines < mineCount)
            {
                int x = random.Next(boardSize);
                int y = random.Next(boardSize);

                if (board[x, y] != 'M')
                {
                    board[x, y] = 'M';
                    IncrementAdjacentCells(x, y);
                    placedMines++;
                }
            }
        }

        static void IncrementAdjacentCells(int x, int y)
        {
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i >= 0 && i < boardSize && j >= 0 && j < boardSize && board[i, j] != 'M')
                    {
                        board[i, j]++;
                    }
                }
            }
        }

        static void PlayGame()
        {
            while (true)
            {
                DisplayBoard();
                Console.WriteLine("Satır ve sütun numarasını boşluklu olarak giriniz (örneğin, 5 10): ");
                string[] input = Console.ReadLine().Split();

                if (input.Length != 2 || !int.TryParse(input[0], out int row) || !int.TryParse(input[1], out int col))
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen iki sayı giriniz.");
                    continue;
                }

                // Kullanıcıdan alınan 1-20 aralığını, 0-19 aralığına dönüştürüyoruz
                row -= 1;
                col -= 1;

                if (row < 0 || row >= boardSize || col < 0 || col >= boardSize)
                {
                    Console.WriteLine("Geçersiz koordinat. Tahtanın boyutuna uygun değerler giriniz.");
                    continue;
                }

                if (board[row, col] == 'M')
                {
                    Console.WriteLine("Mayına bastınız! Oyun bitti.");
                    DisplayBoard(true);
                    break;
                }
                else
                {
                    RevealCell(row, col);
                    if (CheckWin())
                    {
                        Console.WriteLine("Tebrikler, oyunu kazandınız!");
                        DisplayBoard(true);
                        break;
                    }
                }
            }
        }

        static void RevealCell(int row, int col)
        {
            if (row < 0 || row >= boardSize || col < 0 || col >= boardSize || revealed[row, col])
                return;

            revealed[row, col] = true;

            if (board[row, col] == '0')
            {
                for (int i = row - 1; i <= row + 1; i++)
                {
                    for (int j = col - 1; j <= col + 1; j++)
                    {
                        if (i != row || j != col)
                            RevealCell(i, j);
                    }
                }
            }
        }

        static bool CheckWin()
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (board[i, j] != 'M' && !revealed[i, j])
                        return false;
                }
            }
            return true;
        }

        static void DisplayBoard(bool showMines = false)
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (revealed[i, j])
                        Console.Write(board[i, j] + " ");
                    else if (showMines && board[i, j] == 'M')
                        Console.Write("M ");
                    else
                        Console.Write("# ");
                }
                Console.WriteLine();
            }
        }
    }
}
