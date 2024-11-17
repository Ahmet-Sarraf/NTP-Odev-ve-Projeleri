using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tek_Yonlu_Iliski
{
    // Yazar Kitap 
    public class Kitap
    {
       public string Baslık { get; set; }
        public string ISBN { get; set; }
    }
   
    public class Yazar
    {
        public string AD { get; set; }
        public string Ulke { get; set; }
        public List<Kitap> Kitaplar { get; set; }

        public void KitapEkle()
        {
            Kitaplar = new List<Kitap>();
        }
    }

    //Çalışan Departman
    public class Departman
    {
        string Ad { get; set; }
        string Lokasyon { get; set; }

        public Departman(string ad, string lokasyon)
        {
            Ad = ad;
            Lokasyon = lokasyon;
        }
    }
    
    public class Calısan
    {
        string Ad { get; set; }
        string pozisyon { get; set; }
        Departman Departman;

        public void DepoartmanAtama(Departman departman)
        {
            Departman = departman;
        }
    }

    // Ürün Sipariş
    public class Urun
    {
        public string Ad { get; set; }
        int Fiyat { get; set; }

        public Urun(string ad, int fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }

        public void UrunBilgileri()
        {
            Console.WriteLine($"Ürün Adı: {Ad}, Fiyat: {Fiyat} TL");
        }
    }

    public class Siparis
    {
        public DateTime Tarih { get; set; }
        public string Durum { get; set; }
        public List<Urun> Urunler { get; set; } = new List<Urun>();

        public void SiparisDetaylari()
        {
            Console.WriteLine($"Sipariş Tarihi: {Tarih}, Durum: {Durum}");
            Console.WriteLine("Ürünler:");
            foreach (var urun in Urunler)
            {
                urun.UrunBilgileri();
            }
        }
    }

    //Müşteri Sipariş
    public class Sıparis
    {
        public DateTime Tarih { get; set; }
        public string Durum { get; set; }
    }

    public class Musteri
    {
        public string Ad { get; set; }
        public string Telefon { get; set; }

        public void SiparisVer()
        {
            Sıparis siparis;

        }
    }







    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
