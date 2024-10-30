using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Soru
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tapınağa giden kapıyı açmak için doğru dizilimi bulun!");

            // Kullanıcıdan sayı dizisini alalım
            List<int> sayilar = new List<int> { 3, 5, 7, 2 }; // Örnek sayı dizisi
            List<string> operatörler = new List<string> { "+", "-", "*", "/" }; // Kullanılabilir operatörler
            int hedefSonuc = 10; // Hedef sonuç (örnek olarak)

            // Dizilim bulmak için deneme işlemi
            BulDizilim(sayilar, operatörler, hedefSonuc);
            Console.ReadKey();
        }

        static void BulDizilim(List<int> sayilar, List<string> operatörler, int hedefSonuc)
        {
            foreach (string op1 in operatörler)
            {
                foreach (string op2 in operatörler)
                {
                    foreach (string op3 in operatörler)
                    {
                        // Dizilim: sayı1 op1 sayı2 op2 sayı3 op3 sayı4
                        int sonuc = Hesapla(sayilar[0], sayilar[1], op1);
                        sonuc = Hesapla(sonuc, sayilar[2], op2);
                        sonuc = Hesapla(sonuc, sayilar[3], op3);

                        // Sonucu kontrol et
                        if (sonuc == hedefSonuc && sonuc > 0)
                        {
                            Console.WriteLine($"Doğru dizilim bulundu: {sayilar[0]} {op1} {sayilar[1]} {op2} {sayilar[2]} {op3} {sayilar[3]} = {sonuc}");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("Doğru dizilim bulunamadı.");
        }

        static int Hesapla(int a, int b, string operatör)
        {
            switch (operatör)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return b != 0 ? a / b : int.MaxValue; // Bölme sıfır kontrolü
                default:
                    return 0;
            }
        }
    }
}
