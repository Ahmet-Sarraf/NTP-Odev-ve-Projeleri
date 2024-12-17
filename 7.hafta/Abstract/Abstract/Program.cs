using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    //BANKA SINIFI (1.ÖDEV)
    // IBankaHesabi arayüzü
    public interface IBankaHesabi
    {
        DateTime HesapAcilisTarihi { get; }
        void HesapOzeti();
    }

    // Soyut Hesap sınıfı
    public abstract class Hesap : IBankaHesabi
    {
        public int HesapNo { get; private set; }
        public decimal Bakiye { get; protected set; }
        public DateTime HesapAcilisTarihi { get; private set; }

        protected Hesap(int hesapNo, decimal bakiye)
        {
            HesapNo = hesapNo;
            Bakiye = bakiye;
            HesapAcilisTarihi = DateTime.Now;
        }

        public abstract void ParaYatir(decimal miktar);

        public abstract void ParaCek(decimal miktar);

        public virtual void HesapOzeti()
        {
            Console.WriteLine($"Hesap No: {HesapNo}\nBakiye: {Bakiye:N2} TL\nAçılış Tarihi: {HesapAcilisTarihi}");
        }
    }

    // BirikimHesabi sınıfı
    public class BirikimHesabi : Hesap
    {
        public decimal FaizOrani { get; private set; }

        public BirikimHesabi(int hesapNo, decimal bakiye, decimal faizOrani) : base(hesapNo, bakiye)
        {
            FaizOrani = faizOrani;
        }

        public override void ParaYatir(decimal miktar)
        {
            if (miktar <= 0)
                throw new ArgumentException("Yatırılan miktar sıfırdan büyük olmalıdır.");

            decimal faiz = miktar * FaizOrani;
            Bakiye += miktar + faiz;
            Console.WriteLine($"{miktar:N2} TL yatırıldı. {faiz:N2} TL faiz eklendi. Yeni bakiye: {Bakiye:N2} TL");
        }

        public override void ParaCek(decimal miktar)
        {
            if (miktar > Bakiye)
                throw new InvalidOperationException("Yetersiz bakiye.");

            Bakiye -= miktar;
            Console.WriteLine($"{miktar:N2} TL çekildi. Yeni bakiye: {Bakiye:N2} TL");
        }
    }

    // VadesizHesap sınıfı
    public class VadesizHesap : Hesap
    {
        private const decimal IslemUcreti = 2.50m;

        public VadesizHesap(int hesapNo, decimal bakiye) : base(hesapNo, bakiye) { }

        public override void ParaYatir(decimal miktar)
        {
            if (miktar <= 0)
                throw new ArgumentException("Yatırılan miktar sıfırdan büyük olmalıdır.");

            Bakiye += miktar;
            Console.WriteLine($"{miktar:N2} TL yatırıldı. Yeni bakiye: {Bakiye:N2} TL");
        }

        public override void ParaCek(decimal miktar)
        {
            decimal toplamCekim = miktar + IslemUcreti;

            if (toplamCekim > Bakiye)
                throw new InvalidOperationException("Yetersiz bakiye.");

            Bakiye -= toplamCekim;
            Console.WriteLine($"{miktar:N2} TL çekildi. İşlem ücreti: {IslemUcreti:N2} TL. Yeni bakiye: {Bakiye:N2} TL");
        }
    }

    //ÜRÜN SINIFI(2.Ödev)
    public abstract class Urun
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        public Urun(string ad, double fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }


        public abstract double HesapOdeme();
        public abstract void BilgiYazdırma();
    }


    public class Kitap : Urun
    {
        public int KitapKodu { get; set; }

        public Kitap(string ad, double fiyat, int kitapkodu)
       : base(ad, fiyat)
        {
            KitapKodu=kitapkodu;
        }

        public override double HesapOdeme()
        {
            
            return Fiyat += Fiyat * 0.1;


        }

        public override void BilgiYazdırma()
        {
            HesapOdeme();
            Console.WriteLine($"Kitap Kodu:{KitapKodu}, Kitap Adı:{Ad}, Kitap Fiyatı:{Fiyat} ");
        }
    }

    public class Elektronik : Urun
    {
        public string Marka { get; set; }

        public Elektronik(string ad, double fiyat, string marka)
       : base(ad, fiyat)
        {
            Marka=marka;
        }
        public override double HesapOdeme()
        {
            
            return Fiyat += Fiyat * 0.25;
        }

        public override void BilgiYazdırma()
        {
            
            HesapOdeme();
            Console.WriteLine($"Ürünün Adı:{Ad}, Ürününün fiyatı:{Fiyat}, Ürün Markası:{Marka}");
        }
    }

    //YAYINCI VE ABONE SİSTEMİ(3.Ödev)

    public interface IYayinci
    {
        void AboneEkle(IAbone abone);
        void AboneCikar(IAbone abone);
        void BildirimGonder(string mesaj);
    }

    
    public interface IAbone
    {
        void BilgiAl(string mesaj);
    }

    
    public class Yayinci : IYayinci
    {
        public List<IAbone> aboneler = new List<IAbone>();

        public void AboneEkle(IAbone abone)
        {
            aboneler.Add(abone);
            Console.WriteLine("Yeni abone eklendi.");
        }

        public void AboneCikar(IAbone abone)
        {
            aboneler.Remove(abone);
            Console.WriteLine("Bir abone çıkarıldı.");
        }

        public void BildirimGonder(string mesaj)
        {
            Console.WriteLine("Tüm abonelere bildirim gönderiliyor...");
            foreach (var abone in aboneler)
            {
                abone.BilgiAl(mesaj);
            }
        }
    }

    
    public class Abone : IAbone
    {
        public string Ad { get; set; }

        public Abone(string ad)
        {
            Ad = ad;
        }

        public void BilgiAl(string mesaj)
        {
            Console.WriteLine($"{Ad} adlı aboneye bildirim: {mesaj}");
        }
    }


    public class Program
    {
        public static void Main()
        {

            /* Banka Sınıfı Deneme
            try
            {
                // Birikim Hesabı oluştur
                BirikimHesabi birikimHesabi = new BirikimHesabi(1001, 5000, 0.05m);
                birikimHesabi.ParaYatir(1000);
                birikimHesabi.ParaCek(200);
                birikimHesabi.HesapOzeti();

                Console.WriteLine();

                // Vadesiz Hesap oluştur
                VadesizHesap vadesizHesap = new VadesizHesap(2001, 3000);
                vadesizHesap.ParaYatir(500);
                vadesizHesap.ParaCek(700);
                vadesizHesap.HesapOzeti();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
            Console.ReadKey();*/


            /* Ürün Sınıfı Deneme
            List<Urun> urunler = new List<Urun>();
            urunler.Add(new Kitap("Nutuk", 200, 1));
            urunler.Add(new Elektronik("Telefon", 300000, "Samsung"));
            Console.WriteLine("Ürün Listesi: ");
            foreach(var urun in urunler)
            {
                urun.BilgiYazdırma();
            }
            Console.ReadKey(); */




            /* Yayıncı ve Abone Sistemi deneme
            Yayinci yayinci = new Yayinci();

           
            IAbone abone1 = new Abone("Ahmet");
            IAbone abone2 = new Abone("Ayşe");
            IAbone abone3 = new Abone("Mehmet");

            
            yayinci.AboneEkle(abone1);
            yayinci.AboneEkle(abone2);
            yayinci.AboneEkle(abone3);

            Console.WriteLine();

            
            yayinci.BildirimGonder("Yeni bir kitap yayınlandı!");

            Console.WriteLine();

            
            yayinci.AboneCikar(abone2);

            Console.WriteLine();

           
            yayinci.BildirimGonder("Yeni bir dergi yayınlandı!");

            Console.ReadKey();*/


        }
    }

}
