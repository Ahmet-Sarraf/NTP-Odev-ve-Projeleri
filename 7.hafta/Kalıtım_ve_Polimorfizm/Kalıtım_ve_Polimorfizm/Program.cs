using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım_ve_Polimorfizm
{
    //ÇALIŞAN SINIFI (1.ÖDEV)
    class Calısan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Maas { get; set; }
        public string Poizsyon { get; set; }

        public virtual void Bilgiyazdir()
        {
            Console.WriteLine($"Ad:{Ad}, Soyad:{Soyad}, Maas:{Maas}, Pozisyon:{Poizsyon}");
        }
    }

    class Yazilimci : Calısan
    {
        public string YazılımDili { get; set; }

        public override void Bilgiyazdir()
        {
            base.Bilgiyazdir();
            Console.WriteLine($"Yazılım Dili:{YazılımDili}");

        }
    }

    class Muhasebeci : Calısan
    {
        public string MuhasebeYazılımı { get; set; }

        public override void Bilgiyazdir()
        {
            base.Bilgiyazdir();
            Console.WriteLine($"Kullanılan Muhasebe Yazılımı: {MuhasebeYazılımı}");
        }
    }

    //HAYVAN SINIFI(2.ÖDEV)
    public class Hayvan
    {
        public string Ad { get; set; }
        public string Tur { get; set; }
        public int Yas { get; set; }

        public Hayvan(string ad, string tur, int yas)
        {
            Ad = ad;
            Tur = tur;
            Yas = yas;
        }

        public virtual void SesCıkar()
        {
            
        }
        public virtual void BilgiYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Tür: {Tur}, Yaş: {Yas}");
        }
    }


    public class Memeli : Hayvan
    {
        public string TuyRengi { get; set; }

        public Memeli(string ad, string tur, int yas, string tuyRengi)
            : base(ad, tur, yas)
        {
            TuyRengi = tuyRengi;
        }
        public override void SesCıkar()
        {
            base.SesCıkar();
            Console.WriteLine("Mırr, hırlama veya başka bir ses.");
        }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.Write($"Tüy Rengi:{TuyRengi}");
        }
    }

    public class Kus : Hayvan
    {
        public double KanatGenisligi { get; set; }

        public Kus(string ad, string tur, int yas, double kanatGenisligi)
            : base(ad, tur, yas)
        {
            KanatGenisligi = kanatGenisligi;
        }

        public override void SesCıkar()
        {
            base.SesCıkar();
            Console.WriteLine("Cik cik, ötme veya başka bir ses.");
        }

        public new void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.WriteLine($"Kanat Genişliği: {KanatGenisligi} metre");
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            /*Calısan sınıfı
            
            Calısan calısan;
            Console.WriteLine("Çalışan Meslağini Giriniz(1:Yazılımcı, 2:Muhasebeci):");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                calısan = new Yazilimci();
                Console.WriteLine("Sırasıyla Çalışanın Adını, Soyadını, Maaşını, Pozisyonunu ve Kullanıdğı Yazılım Dilini Giriniz:");
                calısan.Ad = Console.ReadLine();
                calısan.Soyad = Console.ReadLine();
                calısan.Maas = double.Parse(Console.ReadLine());
                calısan.Poizsyon = Console.ReadLine();
                ((Yazilimci)calısan).YazılımDili = Console.ReadLine();
            }
            else if (secim == 2)
            {
                calısan = new Muhasebeci();
                Console.WriteLine("Sırasıyla Çalışanın Adını, Soyadını, Maaşını, Pozisyonunu ve Kullanıdğı Muhasebe Yazılımını Girin:");
                calısan.Ad = Console.ReadLine();
                calısan.Soyad = Console.ReadLine();
                calısan.Maas = double.Parse(Console.ReadLine());
                calısan.Poizsyon = Console.ReadLine();
                ((Muhasebeci)calısan).MuhasebeYazılımı = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hatalı seçim sistem kapanıyor!");
                return;
            }

            calısan.Bilgiyazdir();
            Console.ReadKey();*/

            /*Hayvan Sınıfı

            Hayvan hayvan;
            Console.WriteLine("Hayvan Türünü Giriniz(1-Memeli, 2-Kuş):");
            int secim2 = int.Parse(Console.ReadLine());

            if (secim2 == 1)
            {
                Console.WriteLine("Memelinin adını giriniz:");
                string ad = Console.ReadLine();

                Console.WriteLine("Memelinin türünü giriniz:");
                string tur = Console.ReadLine();

                Console.WriteLine("Memelinin yaşını giriniz:");
                int yas = int.Parse(Console.ReadLine());

                Console.WriteLine("Memelinin tüy rengini giriniz:");
                string tuyRengi = Console.ReadLine();

                hayvan = new Memeli(ad, tur, yas, tuyRengi);
            }
            else if (secim2 == 2)
            {
                Console.WriteLine("Kuşun adını giriniz:");
                string ad = Console.ReadLine();

                Console.WriteLine("Kuşun türünü giriniz:");
                string tur = Console.ReadLine();

                Console.WriteLine("Kuşun yaşını giriniz:");
                int yas = int.Parse(Console.ReadLine());

                Console.WriteLine("Kuşun kanat genişliğini giriniz (metre):");
                double kanatGenisligi = double.Parse(Console.ReadLine());

                hayvan = new Kus(ad, tur, yas, kanatGenisligi);
            }
            else
            {
                Console.WriteLine("Hatalı giriş Sistem kapanıyıor!");
                return;
            }

            hayvan.SesCıkar();
            hayvan.BilgiYazdir();
            Console.ReadKey();*/


        }
    }
}
