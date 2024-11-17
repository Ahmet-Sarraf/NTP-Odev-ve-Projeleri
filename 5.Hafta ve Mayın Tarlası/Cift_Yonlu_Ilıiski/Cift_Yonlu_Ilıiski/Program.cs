using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cift_Yonlu_Ilıiski
{
    class Program
    {
        // Doktor ve Hasta 
        public class Doktor
        {
            public string Ad { get; set; }
            public string Brans { get; set; }
            public List<Hastalar> hasta;

            public Doktor(string ad,string brans)
            {
                Ad = ad;
                Brans = brans;
                hasta = new List<Hastalar>();
            }
            
            public void HastaEkle(Hastalar Hasta)
            {
                if (!hasta.Contains(Hasta))
                {
                    hasta.Add(Hasta);
                }
            }
        }

        public class Hastalar
        {
            public string Ad { get; set; }
            public string TCNo { get; set; }
            Doktor Doktor;

            public Hastalar(string ad, string soyad)
            {
                Ad = ad;
                soyad = soyad;
            }
            
            public void DoktorAtama(string ad,string brans)
            {
                Doktor = new Doktor(ad, brans);
            }
        }

        //Yazar Kitap
        public class Yazar
        {
            public string Ad { get; set; }
            public string Ulke { get; set; }
            public List<Kitap> Kitaplar { get; set; }

            public Yazar(string ad, string ulke)
            {
                Ad = ad;
                Ulke = ulke;
                Kitaplar = new List<Kitap>();
            }

            public void KitapEKle(Kitap kitap)
            {
                if (Kitaplar.Contains(kitap))
                {
                    Kitaplar.Add(kitap);
                }
            }
        }
        
        public class Kitap
        {
            public string Baslık { get; set; }
            public DateTime YayinTarihi { get; set; }
            public Yazar Yazar;

            public Kitap(string baslık, DateTime yayıntarihi)
            {
                Baslık = baslık;
                YayinTarihi = yayıntarihi;
            }

            public void YazarAtama(string Ad, string Ulke)
            {
                Yazar = new Yazar(Ad, Ulke);
            }
        }

        //Şirket ve Çalışan
        public class Sirket
        {
            public string Ad { get; set; }
            public string Konum { get; set; }
            public List<Calısanlar> Calısan { get; set; }

            public Sirket(String ad, string konum)
            {
                Ad = ad;
                Konum = konum;
                Calısan = new List<Calısanlar>();
            }

            public void CalısanEkle(Calısanlar calısan)
            {
                if (!Calısan.Contains(calısan))
                {
                    Calısan.Add(calısan);
                }
            }
        }

        public class Calısanlar
        {
            public string Ad { get; set; }
            public string Departman { get; set; }
            Sirket sirket;
            
            public Calısanlar(string ad, string departman)
            {
                Ad = ad;
                Departman = departman;

            }

            public void SirketEkleme(string Ad, string Konum)
            {
                sirket = new Sirket(Ad, Konum);
            }

        }

        //Ebeveyn Çocuk
        public class Ebeveyn
        {
            public string Ad { get; set; }
            public int Yas { get; set; }
            public List<Cocuk> Cocuklar { get; set; }

            public Ebeveyn(String ad,int yas)
            {
                Ad = ad;
                Yas = yas;
                Cocuklar = new List<Cocuk>();
            }

            public void CocukEkle(Cocuk cocuk)
            {
                if (!Cocuklar.Contains(cocuk))
                {
                    Cocuklar.Add(cocuk);
                }
            }
        }
        
        public class Cocuk
        {
            public string Ad { get; set; }
            public int Yas { get; set; }
            Ebeveyn ebeveyn;

            public Cocuk(string ad, int yas)
            {
                Ad = ad;
                Yas = yas;
            }

            public void EbevbeynAtama(String Ad, int Yas)
            {
                ebeveyn = new Ebeveyn(Ad, Yas);
            }
        }



        static void Main(string[] args)
        {
        }
    }
}
