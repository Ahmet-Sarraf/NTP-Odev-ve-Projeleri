using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asal_Toplam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 0; // Asal sayıların toplamı

            for (int i = 2; i <= n; i++)
            {
                bool asalMi = true; // Sayının asal olup olmadığını takip etmek için değişken

                // 2'den i'nin kareköküne kadar olan sayılarla kontrol
                for (int j = 2; j *j <= i; j++)
                {
                    if (i % j == 0) // Sayı herhangi bir sayıya tam bölünüyorsa asal değildir
                    {
                        asalMi = false; // Asal olmadığını belirt
                        break; // Döngüyü bitir, çünkü asal olmadığını bulduk
                    }
                }

                if (asalMi) // Eğer asal ise toplamaya ekle
                {
                    toplam += i;
                }
            }

            Console.WriteLine("Girilen sayıya kadar olan asal sayıların toplamı: " + toplam);
            Console.ReadKey();


        }
        
    }
}
