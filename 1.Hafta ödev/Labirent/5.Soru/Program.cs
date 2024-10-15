using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Soru
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] labirent = {
            { 1, 0, 1, 1 },
            { 1, 1, 0, 1 },
            { 0, 1, 1, 0 },
            { 1, 0, 1, 1 }
        };

            int sonuc = EnKisaYol(labirent);
            if (sonuc != -1)
            {
                Console.WriteLine("Hazineye ulaşmak için gereken adım sayısı: " + sonuc);
            }
            else
            {
                Console.WriteLine("Yol Yok");
            }
            Console.ReadKey();
        }

        static int EnKisaYol(int[,] labirent)
        {
            int N = labirent.GetLength(0);
            int[,] ziyaretEdilen = new int[N, N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    ziyaretEdilen[i, j] = -1;

            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            queue.Enqueue(new Tuple<int, int>(0, 0));
            ziyaretEdilen[0, 0] = 0;

            int[] dx = { 1, -1, 0, 0 }; // Aşağı, yukarı, sağ, sol
            int[] dy = { 0, 0, 1, -1 };

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                int x = current.Item1;
                int y = current.Item2;

                // Hazine noktasına ulaşıldı mı?
                if (x == N - 1 && y == N - 1)
                    return ziyaretEdilen[x, y];

                // Komşu hücreleri kontrol et
                for (int i = 0; i < 4; i++)
                {
                    int newX = x + dx[i];
                    int newY = y + dy[i];

                    if (newX >= 0 && newX < N && newY >= 0 && newY < N &&
                        labirent[newX, newY] == 1 && ziyaretEdilen[newX, newY] == -1)
                    {
                        ziyaretEdilen[newX, newY] = ziyaretEdilen[x, y] + 1;
                        queue.Enqueue(new Tuple<int, int>(newX, newY));
                    }
                }
            }

            // Hazineye ulaşılamıyorsa
            return -1;
        }
    }
}
