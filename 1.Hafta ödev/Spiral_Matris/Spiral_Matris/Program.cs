using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral_Matris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir N sayısı girin (N x N matris için): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            int value = 1;
            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = n - 1;

            while (value <= n * n)
            {
                // Üst kenar
                for (int i = left; i <= right; i++)
                {
                    matrix[top, i] = value++;
                }
                top++;

                // Sağ kenar
                for (int i = top; i <= bottom; i++)
                {
                    matrix[i, right] = value++;
                }
                right--;

                // Alt kenar
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        matrix[bottom, i] = value++;
                    }
                    bottom--;
                }

                // Sol kenar
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        matrix[i, left] = value++;
                    }
                    left++;
                }
            }

            // Matrisi yazdırma
            Console.WriteLine("Spiral sırayla yazdırılan matris:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    
}
