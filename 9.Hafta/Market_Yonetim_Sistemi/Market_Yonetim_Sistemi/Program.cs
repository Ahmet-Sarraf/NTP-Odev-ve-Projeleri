using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Yonetim_Sistemi
{
    // Ödeme Yöntemleri
    public abstract class OdemeYontemi
    {
        public abstract void OdemeYap(double miktar);
    }

    public class KrediKartı : OdemeYontemi
    {
        public override void OdemeYap(double miktar)
        {
            Console.WriteLine($"{miktar}TL Kredi Kartı ile Ödendi");
        }
    }

    public class Nakit: OdemeYontemi
    {
        public override void OdemeYap(double miktar)
        {
            Console.WriteLine($"{miktar}Tl Nakit Ödendi");
        }
    }

    public class Havale : OdemeYontemi
    {
        public override void OdemeYap(double miktar)
        {
            Console.WriteLine($"{miktar} Havale ile Ödendi");
        }
    }

    //İndirimler
    public abstract class Indırım
    {
        public abstract double IndırımUygula(double tutar);
    }

    public class YuzdelikIndirim : Indırım
    {
        private double Yuzde;

        public YuzdelikIndirim(double yuzde)
        {
            Yuzde = yuzde;
        }

        public override double IndırımUygula(double tutar)
        {
            return tutar - (tutar * Yuzde - 100);
        }
    }

    public class SabitTutar : Indırım
    {
        private double Sabit;

        public SabitTutar(double sabit)
        {
            Sabit = sabit;
        }

        public override double IndırımUygula(double tutar)
        {
            return tutar - Sabit;
        }
    }

    //Müşteri Sınıfı
    public abstract class Musteri
    {
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }

        public abstract void SepeteUrunEkle(Urun urun);
        public abstract void OdemeYap(OdemeYontemi odemeYontemi, double miktar);
    }

    public class BireyselMusteri : Musteri
    {
        public double KrediPuanı { get; set; }
        public override void SepeteUrunEkle(Urun urun)
        {
            Console.WriteLine($"{urun.Adi} ürününü bireysel müşteri sepetine ekledi.");
        }

        public override void OdemeYap(OdemeYontemi odemeYontemi, double miktar)
        {
            odemeYontemi.OdemeYap(miktar);
        }
    }

    public class KurumsalMusteri : Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNumarasi { get; set; }

        public override void SepeteUrunEkle(Urun urun)
        {
            Console.WriteLine($"{urun.Adi} ürününü kurumsal müşteri sepetine ekledi.");
        }

        public override void OdemeYap(OdemeYontemi odemeYontemi, double miktar)
        {
            odemeYontemi.OdemeYap(miktar);
        }
    }

    // Urun Sınıfı
    public class Urun
    {
        public string Adi { get; set; }
        public double Fiyat { get; set; }
        public int StokMiktari { get; set; }
        public string Kategori { get; set; }

        public Urun(string adi, double fiyat, int stokMiktari, string kategori)
        {
            Adi = adi;
            Fiyat = fiyat;
            StokMiktari = stokMiktari;
            Kategori = kategori;
        }

    }

    // Sepet Sınıfı
    public class Sepet
    {
        public List<Urun> Urunler { get; set; } = new List<Urun>();

        public void UrunEkle(Urun urun)
        {
            Urunler.Add(urun);
            Console.WriteLine($"{urun.Adi} Sepete Eklendi");
        }

        public double ToplamTutarHesapla()
        {
            return Urunler.Sum(urun => urun.Fiyat);
        }

        public double IndirimUygula(Indırım indirim)
        {
            double toplam = ToplamTutarHesapla();
            return indirim.IndırımUygula(toplam);
        }
    }

    // Sıpariş Sınıfı
    public class Siparis
    {
        public int SiparisID { get; set; }
        public Musteri Musteri { get; set; }
        public Sepet Sepet { get; set; }
        public string Durum { get; set; }

        public Siparis(int siparisID, Musteri musteri, Sepet sepet)
        {
            SiparisID = siparisID;
            Musteri = musteri;
            Sepet = sepet;
            Durum = "Onaylandı";  
        }

        public void DurumDegistir(string yeniDurum)
        {
            Durum = yeniDurum;
            Console.WriteLine($"Sipariş durumu {Durum} olarak değiştirildi.");
        }
    }
    // Stokta Olmama veya Ödeme Gerçekleştirememe Durumunda Ortaya Çıkan Hatalar
    public class StoktaYokException : Exception
    {
        public StoktaYokException(string message) : base(message) { }
    }

    public class OdemeBasarisizException : Exception
    {
        public OdemeBasarisizException(string message) : base(message) { }
    }



    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ürün oluşturuluyor
                Urun elma = new Urun("Elma", 5.00, 10, "Meyve");

                // Müşteri oluşturuluyor
                Musteri bireyselMusteri = new BireyselMusteri { Ad = "Ahmet Yılmaz" };
                bireyselMusteri.SepeteUrunEkle(elma);

                // Sepet oluşturuluyor
                Sepet sepet = new Sepet();
                sepet.UrunEkle(elma);

                // Ödeme metodu seçiliyor
                OdemeYontemi odemeMetodu = new KrediKartı();

                // İndirim uygulaması
                Indırım indirim = new YuzdelikIndirim(10);
                double toplamTutar = sepet.ToplamTutarHesapla();
                double indirimliTutar = sepet.IndirimUygula(indirim);

                // Ödeme yapılıyor
                bireyselMusteri.OdemeYap(odemeMetodu, indirimliTutar);

                // Sipariş oluşturuluyor
                Siparis siparis = new Siparis(1, bireyselMusteri, sepet);
                siparis.DurumDegistir("Hazırlanıyor");
            }
            catch (StoktaYokException ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
            catch (OdemeBasarisizException ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Beklenmeyen hata: {ex.Message}");
            }

            Console.ReadKey();
        }


    }
}
