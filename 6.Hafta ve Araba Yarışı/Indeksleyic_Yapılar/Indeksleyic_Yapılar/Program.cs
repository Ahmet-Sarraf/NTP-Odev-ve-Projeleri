using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indeksleyic_Yapılar
{
    //Özel Kitaplık Yönetim
    public class Kitaplar
    {
        private string[] Kitap = { "Tutunamayanlar", "Şeker Portakalı", "Güneşi Uyandırlarım", "Çalı Kuşu" };

        public string this[int index]
        {
            get
            {
                if(index<0 || index >= Kitap.Length)
                {
                    return "Kitap Bulunamadı";
                }
                return Kitap[index];
            }
            set
            {
                Kitap[index] = value;
            }
        }
    }

    //Öğrenci Not Sistemi
    public class OgrenciNotlar
    {
        private Dictionary<string, int> dersNotları = new Dictionary<string, int>();
        public int this[string dersAdı]
        {
            get
            {
                if (dersNotları.ContainsKey(dersAdı))
                    return dersNotları[dersAdı];
                else
                    throw new KeyNotFoundException("Bu ders bulunamadı: " + dersAdı);
            }
            set
            {
                dersNotları[dersAdı] = value;
            }
        }
    }

    // Satranç Tahtası Durumu
    public class SatrancTahtası
    {
        private string[,] Tahta = new string[8, 8];

        public string this[int satır, int sutun]
        {
            get
            {
                if (satır < 0 || satır >= 8 || sutun < 0 || sutun >= 8)
                {
                    throw new IndexOutOfRangeException("Geçersiz kare: Satır ve sütun 0 ile 7 arasında olmalıdır.");
                }

                if (Tahta[satır, sutun] == null)
                    return "Boş";

                return Tahta[satır, sutun];
            }
            set
            {
                if (satır < 0 || satır >= 8 || sutun < 0 || sutun >= 8)
                {
                    throw new IndexOutOfRangeException("Geçersiz kare: Satır ve sütun 0 ile 7 arasında olmalıdır.");
                }

                Tahta[satır, sutun] = value;
            }
        }
    }

    // Çok Katmanlı Otopark Sistemi
    public class OtoPark
    {
        private string[,] Otopark = new string[5,10];
        
        public OtoPark()
        {
            for (int i = 0; i < Otopark.GetLength(0); i++)  
            {
                for (int j = 0; j < Otopark.GetLength(1); j++)  
                {
                    Otopark[i, j] = "Empty";
                    
                }
            }
        }
        

        public string this[int kat,int yer]
        {
            get
            {
                if (kat < 0 || kat >= 9 || yer < 0 || yer >= 9)
                    throw new IndexOutOfRangeException("Geçeçrsız kat veya alan");
                return Otopark[kat, yer];
            }
            set
            {
                if (kat < 0 || kat >=5 || yer < 0 || yer >= 9)
                {
                    throw new IndexOutOfRangeException("Geçersiz kat veya park yeri.");
                }

                Otopark[kat, yer] = value;
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
