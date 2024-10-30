using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Soru
{
    class Program
    {
        static void Main()
        {
            string encryptedMessage = "Şifrelenmiş mesaj buraya girilecek";

            // Şifre çözümü adımları
            string decryptedMessage = SifreCoz(encryptedMessage);

            Console.WriteLine("Orijinal Mesaj:");
            Console.WriteLine(decryptedMessage);
            Console.ReadKey();
        }

        static string SifreCoz(string encryptedMessage)
        {
            List<int> fibonacciListesi = FibonacciSerisiOlustur(encryptedMessage.Length);
            List<int> orijinalAsciiDegerler = new List<int>();

            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                int sifreliAscii = (int)encryptedMessage[i];
                int fibonacciCarpani = fibonacciListesi[i];
                int pozisyon = i + 1;
                int orijinalAscii = 0;

                if (AsalMi(pozisyon))
                {
                    // Asal pozisyonlarda mod 100 ile şifrelenmiş
                    for (int j = 0; j < 256; j++)
                    {
                        if ((j * fibonacciCarpani) % 100 == sifreliAscii)
                        {
                            orijinalAscii = j;
                            break;
                        }
                    }
                }
                else
                {
                    // Asal olmayan pozisyonlarda mod 256 ile şifrelenmiş
                    orijinalAscii = (sifreliAscii * ModulerTers(fibonacciCarpani, 256)) % 256;
                }

                orijinalAsciiDegerler.Add(orijinalAscii);
            }

            // ASCII değerlerini karaktere çevirerek orijinal mesajı oluştur
            char[] orijinalMesajKarakterleri = new char[orijinalAsciiDegerler.Count];
            for (int i = 0; i < orijinalAsciiDegerler.Count; i++)
            {
                orijinalMesajKarakterleri[i] = (char)orijinalAsciiDegerler[i];
            }

            return new string(orijinalMesajKarakterleri);
        }

        static List<int> FibonacciSerisiOlustur(int n)
        {
            List<int> fibonacci = new List<int> { 1, 1 };
            for (int i = 2; i < n; i++)
            {
                fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
            }
            return fibonacci;
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

        static int ModulerTers(int sayi, int mod)
        {
            sayi = sayi % mod;
            for (int x = 1; x < mod; x++)
            {
                if ((sayi * x) % mod == 1)
                {
                    return x;
                }
            }
            return 1; // Eğer modüler ters bulunamazsa (nadiren olur)
        }
    }
}
