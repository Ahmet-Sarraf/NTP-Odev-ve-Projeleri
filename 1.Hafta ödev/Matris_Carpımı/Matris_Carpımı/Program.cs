using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris_Carpımı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir N sayısı girin (N x N matris için): ");
            int n;

            // Kullanıcıdan geçerli bir N değeri alma
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Lütfen pozitif bir tam sayı girin.");
            }

            // Matrislerin tanımlanması
            int[,] matrixA = new int[n, n];
            int[,] matrixB = new int[n, n];
            int[,] resultMatrix = new int[n, n];

            // İlk matrisin elemanlarını alma
            Console.WriteLine("Birinci matrisin elemanlarını girin:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"matrixA[{i},{j}]: ");
                    matrixA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // İkinci matrisin elemanlarını alma
            Console.WriteLine("İkinci matrisin elemanlarını girin:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"matrixB[{i},{j}]: ");
                    matrixB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Matris çarpımını hesaplama
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            // Sonucu yazdırma
            Console.WriteLine("Matrislerin çarpımı:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(resultMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
