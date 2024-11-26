using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    // Traik Işık Durumu 
    public enum IsıkDurumu
    {
       Red,
       Yellow,
       Green

    }
    public class Traik_Isıgı 
    {
        public void DurumIslemi (IsıkDurumu durum)
        {
            switch (durum)
            {
                case IsıkDurumu.Red:
                    Console.WriteLine("Durun");
                    break;
                case IsıkDurumu.Yellow:
                    Console.WriteLine("Hazırlan");
                    break;
                case IsıkDurumu.Green:
                    Console.WriteLine("Geç");
                    break;
            }
        }
    }

    // Hava Durumu Tahmini
    enum HavaDurumu
    {
        Sunny, Rainy, Cloudy, Stormy
    }

    class Havadurumu
    {
        public void Durum (HavaDurumu hava)
        {
            switch (hava)
            {
                case HavaDurumu.Sunny:
                    Console.WriteLine("Hava güneşli ince giyinin");
                    break;
                case HavaDurumu.Rainy:
                    Console.WriteLine("Hava yağmurlu şemsiye alın");
                    break;
                case HavaDurumu.Cloudy:
                    Console.WriteLine("Hava bulutlu kalın giyinin");
                    break;
                case HavaDurumu.Stormy:
                    Console.WriteLine("Hava dışarı çıkmayın");
                    break;
                default:
                    throw new Exception("Geçersiz Hava Durumu");
            }
        }
    }

    // Çalışan Rolleri ve Maaş Hesaplama
    enum CalisanRol
    {
        Manager,  
        Developer, 
        Designer,  
        Tester     
    }

    class Calisan
    {

        public double MaasHesapla(CalisanRol Rol )
        {
            switch (Rol)
            {
                case CalisanRol.Manager:
                    return 8000;  
                case CalisanRol.Developer:
                    return 6000;  
                case CalisanRol.Designer:
                    return 4000;  
                case CalisanRol.Tester:
                    return 2000;  
                default:
                    throw new ArgumentException("Geçersiz çalışan rolü");
            }
        }
    }



    class Program
    {

        static void Main(string[] args)
        {
        }
    }
}
