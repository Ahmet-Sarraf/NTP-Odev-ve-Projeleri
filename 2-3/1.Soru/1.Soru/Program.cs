using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Soru
{
    class Program
    {
        static void Main()
        {
            // Kullanıcıdan dizi tam sayıları alma
            Console.WriteLine("Tam sayıları (virgülle ayrılmış) girin: ");
            string input = Console.ReadLine();
            string[] stringSayilar = input.Split(',');

            // Dizi oluşturma ve tam sayılara dönüştürme
            int[] sayilar = Array.ConvertAll(stringSayilar, int.Parse);

            // Sayıları sıralama
            Array.Sort(sayilar);
            Console.WriteLine("Sıralı sayılar: " + string.Join(", ", sayilar));

            // Kullanıcıdan kontrol edilecek sayıyı alma
            Console.WriteLine("Kontrol edilecek sayıyı girin: ");
            int kontrolSayisi;
            while (!int.TryParse(Console.ReadLine(), out kontrolSayisi))
            {
                Console.WriteLine("Lütfen geçerli bir tam sayı girin.");
            }

            // Sayının dizide olup olmadığını kontrol etme
            if (Array.Exists(sayilar, element => element == kontrolSayisi))
            {
                Console.WriteLine($"{kontrolSayisi} dizide bulunuyor.");
            }
            else
            {
                Console.WriteLine($"{kontrolSayisi} dizide bulunmuyor.");
            }
            Console.ReadKey();
        }
    }
}
