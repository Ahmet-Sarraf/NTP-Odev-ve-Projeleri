using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.soru
{
    class Program
    {
        static void Main()
        {
            int bugunYil = DateTime.Now.Year;
            int bugunAy = DateTime.Now.Month;
            int bugunGun = DateTime.Now.Day;

            List<string> gecerliTarihler = new List<string>();

            for (int yil = Math.Max(2000, bugunYil); yil <= 3000; yil++)
            {
                for (int ay = 1; ay <= 12; ay++)
                {
                    // Günlerin üst sınırını ay ve yıla göre belirleyelim
                    int gunSayisi = DateTime.DaysInMonth(yil, ay);

                    for (int gun = 1; gun <= gunSayisi; gun++)
                    {
                        // Geçerli tarihler aralığında olup olmadığını kontrol ediyoruz
                        if (yil == bugunYil && ay == bugunAy && gun <= bugunGun) continue;

                        if (AsalMi(gun) && AyBasamakToplamiCiftMi(ay) && YilSartiSaglanmisMi(yil))
                        {
                            gecerliTarihler.Add($"{gun:D2}/{ay:D2}/{yil}");
                        }
                    }
                }
            }

            // Tüm geçerli tarihleri yazdır
            foreach (var tarih in gecerliTarihler)
            {
                Console.WriteLine(tarih);
            }
            Console.ReadKey();
        }

        static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false;
            for (int i = 2; i * i <= sayi; i++)
            {
                if (sayi % i == 0) return false;
            }
            return true;
        }

        static bool AyBasamakToplamiCiftMi(int ay)
        {
            int toplam = 0;
            while (ay > 0)
            {
                toplam += ay % 10;
                ay /= 10;
            }
            return toplam % 2 == 0;
        }

        static bool YilSartiSaglanmisMi(int yil)
        {
            int rakamToplami = 0;
            int yilGecici = yil;

            while (yilGecici > 0)
            {
                rakamToplami += yilGecici % 10;
                yilGecici /= 10;
            }

            return rakamToplami < yil / 4;
        }
    }
}
