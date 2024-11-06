using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Soru
{
    class Program
    {

        public class Kitap
        {
            public string Ad { get; set; }
            public string Yazar { get; set; }
            public int SayfaSayısı { get; set; }

            public Kitap(string ad,string yazar,int sayfasayısı)
            {
                Ad = ad;
                Yazar = yazar;
                SayfaSayısı = sayfasayısı;
            }

            public void BilgiGoster()
            {
                Console.WriteLine($"Kitap Adı: {Ad}, Yazar: {Yazar}, Sayfa Sayısı: {SayfaSayısı}");
            }
        }


        public class Kutuphane
        {
            public List <Kitap> Kitaplar { get; private set; }

            public Kutuphane()
            {
                Kitaplar = new List<Kitap>();
            }

            public void KitapEkle(Kitap yeniKitap)
            {
                this.Kitaplar.Add(yeniKitap);
                Console.WriteLine($"{yeniKitap.Ad} adlı kitap kütüphaneye eklendi.");
            }

            public void KitaplariListele()
            {
                Console.WriteLine("\nKütüphanedeki Kitaplar:");
                foreach (var kitap in this.Kitaplar)
                {
                    kitap.BilgiGoster();
                }
            }

        }



        static void Main(string[] args)
        {
        }
    }
}
