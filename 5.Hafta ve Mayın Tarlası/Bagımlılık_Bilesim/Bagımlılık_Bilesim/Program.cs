using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagımlılık_Bilesim
{
    // Bilgisayar İslemci
    public class Islemci
    {
        public int Cekirdek { get; set; }
        public int Frekans { get; set; }

        public Islemci(int cekirdek, int frekans)
        {
            Cekirdek = cekirdek;
            Frekans = frekans;
        }

        public void IslemciBilgi()
        {
            Console.WriteLine($"Çekirdek:{Cekirdek}  Frekans:{Frekans}");
        }
    }

    public class Bilgisayar
    {
        public string Model { get; set; }
        Islemci Islemci;

        public Bilgisayar(string model)
        {
            Model = model;
            Islemci = new Islemci(100, 100);
        }

    }

    // Otomobil Motor
    public class Motor
    {
        int Guc { get; set; }
        public string Tip { get; set; }

        public Motor(int guc,string tip)
        {
            Guc = guc;
            Tip = tip;
        }

        public void MotorBilgisi()
        {
            Console.WriteLine($"Güç:{Guc} Tip{Tip}");
        }
    }

    public class Otomobil
    {
        public string Marka { get; set; }
        Motor Motor;

        public Otomobil(string marka)
        {
            marka = marka;
            Motor = new Motor(2000, "Dizel");
        }
    }

    // Okul Öğrenci
    public class Ogrenci
    {
        public string Ad { get; set; }
        int Yas { get; set; }

        public Ogrenci(string ad, int yas)
        {
            Ad = ad;
            Yas = yas;
        }

        public void OgrenciBilgi()
        {
            Console.WriteLine($"Öğrenci Adı:{Ad} Öğrenci Yaşı{Yas}");
        }
    }    

    public class Okul
    {
        public string Ad { get; set; }
        public List<Ogrenci> Ogrenci { get; set; }

        public Okul(string ad)
        {
            Ad = ad;
            Ogrenci = new List<Ogrenci>();
        }

        public void OgrenciOlustur(Ogrenci ogrenci)
        {
            Ogrenci.Add(ogrenci);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
