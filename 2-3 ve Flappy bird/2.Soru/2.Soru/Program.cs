using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Soru
{
    class Program
    {
            static void Main()
            {
                List<int> sayilar = new List<int>();
                int toplam = 0;
                int sayi;

                // Kullanıcıdan pozitif tam sayıları alma
                Console.WriteLine("Pozitif tam sayıları girin (0 girene kadar):");

                while (true)
                {
                    sayi = Convert.ToInt32(Console.ReadLine());

                    if (sayi == 0)
                        break;

                    if (sayi > 0)
                    {
                        sayilar.Add(sayi);
                        toplam += sayi;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen pozitif bir tam sayı girin.");
                    }
                }

                // Ortalama hesaplama
                double ortalama = (double)toplam / sayilar.Count;

                // Medyan hesaplama
                sayilar.Sort();
                double medyan;
                int n = sayilar.Count;

                if (n % 2 == 0)
                {
                    medyan = (sayilar[n / 2 - 1] + sayilar[n / 2]) / 2.0; // çift sayıda eleman varsa
                }
                else
                {
                    medyan = sayilar[n / 2]; // tek sayıda eleman varsa
                }

                // Sonuçları gösterme
                Console.WriteLine($"Ortalama: {ortalama}");
                Console.WriteLine($"Medyan: {medyan}");
            Console.ReadKey();
            }
    }
}
    

