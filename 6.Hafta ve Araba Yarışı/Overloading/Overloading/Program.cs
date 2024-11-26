using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        // Matematiksel İşlemleri Çeşitlendirme
        public int Toplam(int a,int b)
        {
            return a + b;
        }
        public int Toplam(int a,int b,int c)
        {
            return a + b + c;
        }
        public int Toplam( Array array)
        {
            int sonuc = 0;
            foreach(int x in array)
            {
                sonuc += x;
            }
            return sonuc;
        }

        //Farklı Şekillerin Alanını Hesaplama
        public int Alan(int a)
        {
            return a * a;
        }
        public int Alan(int a,int b)
        {
            return a * b;
        }
        public double Alan(double a)
        {
           double b = Math.PI;
            return a * b * b;
            
        }
        // ZAman farkını hesaplama
        public int TarihFarki(DateTime tarih1, DateTime tarih2)
        {
            return (int)(tarih2 - tarih1).TotalDays;
        }

        
        public double TarihFarki(DateTime tarih1, DateTime tarih2,Boolean saat)
        {
            return (tarih2 - tarih1).TotalHours;
        }


            static void Main(string[] args)
        {
        }
    }
}
