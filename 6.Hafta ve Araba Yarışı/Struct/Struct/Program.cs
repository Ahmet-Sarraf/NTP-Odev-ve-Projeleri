using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{

    //Zaman İşlemnleri
    struct Zaman
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

        public Zaman(int hour,int minute)
        {
            if (hour < 0 || hour >= 24)
                Hour = 0;
            else
                Hour = hour;

            if (minute < 0 || minute >= 60)
                Minute = 0;
            else
                Minute = minute;
        }

        public int ToplamDakika()
        {
            return Hour * 60 + Minute;
        }

        public int Fark(Zaman zaman1,Zaman zaman2)
        {
            return Math.Abs(zaman1.ToplamDakika() - zaman2.ToplamDakika());
        }
    }

    // Karmaşık Sayı Hesaplama
    struct KarmasıkSayı
    {
        public double GercekSayı { get; set; }
        public double SanalSayı { get; set; }
        
        public KarmasıkSayı(double gercek,double sanal)
        {
            GercekSayı = gercek;
            SanalSayı = sanal;
        }
        public static KarmasıkSayı operator +(KarmasıkSayı s1, KarmasıkSayı s2)
        {
            return new KarmasıkSayı(s1.GercekSayı + s2.GercekSayı, s1.SanalSayı + s2.SanalSayı);
        }

        public static KarmasıkSayı operator -(KarmasıkSayı s1, KarmasıkSayı s2)
        {
            return new KarmasıkSayı(s1.GercekSayı - s2.GercekSayı, s1.SanalSayı - s2.SanalSayı);
        }

        public override string ToString()
        {
            
            if (SanalSayı == 0)
                return GercekSayı.ToString();

            
            if (SanalSayı > 0)
                return $"{GercekSayı} + {SanalSayı}i";

            
            return $"{GercekSayı} - {Math.Abs(SanalSayı)}i";
        }

    }

    //GPS Konum Mesafesi
    struct GPSKonum
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        
        public GPSKonum(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        
        public static double Mesafe(GPSKonum konum1, GPSKonum konum2)
        {
            
            double R = 6371; 
            double lat1 = ToRadians(konum1.Latitude);
            double lon1 = ToRadians(konum1.Longitude);
            double lat2 = ToRadians(konum2.Latitude);
            double lon2 = ToRadians(konum2.Longitude);

            double dlat = lat2 - lat1;
            double dlon = lon2 - lon1;

           
            double a = Math.Sin(dlat / 2) * Math.Sin(dlat / 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Sin(dlon / 2) * Math.Sin(dlon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

           
            double mesafe = R * c;
            return mesafe;
        }

        
        private static double ToRadians(double derece)
        {
            return derece * (Math.PI / 180);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
