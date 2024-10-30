using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Soru
{
    using System;

    class Program
    {
        static void Main()
        {
            int[,] enerjiMatrisi = {
            { 4, 7, 8, 6, 4 },
            { 6, 7, 3, 9, 2 },
            { 3, 8, 1, 2, 4 },
            { 7, 1, 7, 3, 7 },
            { 2, 9, 8, 9, 3 }
        };

            int minEnerji = MinEnerjiHarcama(enerjiMatrisi);
            Console.WriteLine("En az enerji harcayarak hedefe ulaşmak için gereken enerji: " + minEnerji);
            Console.ReadKey();
        }

        static int MinEnerjiHarcama(int[,] enerji)
        {
            int N = enerji.GetLength(0);
            int[,] dp = new int[N, N];

            // Başlangıç hücresinin enerji maliyeti
            dp[0, 0] = enerji[0, 0];

            // İlk satır boyunca hareket (sadece sağa hareket edilebilir)
            for (int j = 1; j < N; j++)
            {
                dp[0, j] = dp[0, j - 1] + enerji[0, j];
            }

            // İlk sütun boyunca hareket (sadece aşağıya hareket edilebilir)
            for (int i = 1; i < N; i++)
            {
                dp[i, 0] = dp[i - 1, 0] + enerji[i, 0];
            }

            // Diğer hücreleri doldur (sağa, aşağıya ve çapraz sağa aşağıya hareket)
            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < N; j++)
                {
                    dp[i, j] = enerji[i, j] + Math.Min(dp[i - 1, j], Math.Min(dp[i, j - 1], dp[i - 1, j - 1]));
                }
            }

            // Son hücredeki değer, minimum enerji maliyetidir
            return dp[N - 1, N - 1];
        }
    }
}
