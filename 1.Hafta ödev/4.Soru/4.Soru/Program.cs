using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Soru
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = {
            { 1, 0, 1, 1 },
            { 1, 1, 0, 1 },
            { 0, 1, 1, 0 },
            { 1, 0, 1, 1 }

        };

            List<Tuple<int, int>> robotlar = new List<Tuple<int, int>>()
        {
            new Tuple<int, int>(0, 0),
            new Tuple<int, int>(2, 1),
            new Tuple<int, int>(3, 3)
        };

            Console.WriteLine("Kurtarılan düğüm sayısı: " + KurtarilabilirDugumSayisi(grid, robotlar));
            Console.ReadKey();
        }

        static int KurtarilabilirDugumSayisi(int[,] grid, List<Tuple<int, int>> robotlar)
        {
            int N = grid.GetLength(0);
            bool[,] ziyaretEdilen = new bool[N, N];
            int toplamKurtarilan = 0;

            foreach (var robot in robotlar)
            {
                int x = robot.Item1;
                int y = robot.Item2;

                if (!ziyaretEdilen[x, y] && grid[x, y] == 1)
                {
                    toplamKurtarilan += DFS(grid, ziyaretEdilen, x, y);
                }
            }

            return toplamKurtarilan;
        }

        static int DFS(int[,] grid, bool[,] ziyaretEdilen, int x, int y)
        {
            int N = grid.GetLength(0);
            if (x < 0 || x >= N || y < 0 || y >= N || grid[x, y] == 0 || ziyaretEdilen[x, y])
                return 0;

            ziyaretEdilen[x, y] = true;
            int kurtarilan = 1;

            kurtarilan += DFS(grid, ziyaretEdilen, x + 1, y);
            kurtarilan += DFS(grid, ziyaretEdilen, x - 1, y);
            kurtarilan += DFS(grid, ziyaretEdilen, x, y + 1);
            kurtarilan += DFS(grid, ziyaretEdilen, x, y - 1);

            return kurtarilan;
        }
        
    }
}
