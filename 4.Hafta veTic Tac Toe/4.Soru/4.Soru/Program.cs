using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Soru
{
    class Program
    {

        public class Kisi
        {
            string Ad, Soyad, TelefonNumarası;

            public Kisi(string ad,string soyad,string telefonnumarası)
            {
                Ad = ad;
                Soyad = soyad;
                TelefonNumarası = telefonnumarası;
            }

            public void KisiBilgisi()
            {
                Console.WriteLine($"Adı:{Ad} \nSoyadı:{Soyad} \nTelefon Numarası:{TelefonNumarası}");
            }


        }





        static void Main(string[] args)
        {
            Kisi k1 = new Kisi("Ahmet", "Sarraf", "5555555555");
            k1.KisiBilgisi();
            Console.ReadKey();
        }
    }
}
