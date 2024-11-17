using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bağımlılık_Toplama
{
    // Ev Oda
    public class Oda
    {
        public string Boyut { get; set; }
        public string Tip { get; set; }

        public Oda(string boyut,string tip)
        {
            Boyut = boyut;
            Tip = tip;

        }
    }

    public class Ev
    {
        public string Ad { get; set; }
        public List<Oda> Odalar { get; set; }

        public Ev(string ad)
        {
            Ad = ad;
            Odalar = new List<Oda>();
        }

        public void OdaEkle(Oda oda)
        {
            Odalar.Add(oda);
        }
    }

    //Şirket Çalışan
    public class Calısanlar
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }

        public Calısanlar(string ad, string pozisyon)
        {
            Ad = ad;
            Pozisyon = pozisyon;

        }

        public void CalısanBilgi()
        {
            Console.WriteLine($"İsim:{Ad} Pozisyon:{Pozisyon}");
        }
    }

    public class Sirket
    {
        public string Ad { get; set; }
        public List<Calısanlar> Calısan { get; set; }

        public Sirket(string ad)
        {
            Ad = ad;
            Calısan = new List<Calısanlar>();,
        }

        public void CalısanEkle(Calısanlar calısan)
        {
            Calısan.Add(calısan);
        }
    }

    //Kütüphane Kitap
    public class Kitaplar
    {
        public string Baslık { get; set; }
        public string Yazar { get; set; }

        public Kitaplar(string baslık, string yazar)
        {
            Baslık = baslık;
            Yazar = yazar;
        }
    }

    public class Kutuphane
    {
        public string Ad { get; set; }
        public List<Kitaplar> Kitap;

        public Kutuphane(string ad)
        {
            Ad = ad;
            Kitap = new List<Kitaplar>();
        }

        public void kitapEkle(Kitaplar kitap)
        {
            Kitap.Add(kitap);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
