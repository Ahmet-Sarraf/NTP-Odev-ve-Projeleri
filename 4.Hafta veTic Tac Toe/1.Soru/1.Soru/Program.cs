using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Soru
{
    class Program
    {

        public class BankaHesabı
        {
            public string HesapNumarası;
            private decimal Bakiye;
                
            private decimal bakiye
            {
                get { return Bakiye; }
                set { Bakiye = value; }
            }

            public BankaHesabı(string hesapnumarası, decimal ilkbakiye)
            {
            HesapNumarası = hesapnumarası;
            Bakiye = ilkbakiye;

            }

            public void ParaYatır(decimal miktar)
            {
                if (miktar > 0)
                {
                    Bakiye += miktar;
                    Console.WriteLine($"{miktar}TL Yatırıldı. Bakiyeniz:{Bakiye}");
                }
                else
                {
                    Console.WriteLine("Yatırılıcak miktar 0 ve negatif olamaz!");
                }
            }

            public void ParaCek(decimal miktar)
            {
                if(miktar>0 && miktar <= Bakiye)
                {
                    Bakiye -= miktar;
                    Console.WriteLine($"{miktar}TL para çekildi. Bkiyeniz:{Bakiye}");
                }
                else
                {
                    Console.WriteLine("Çekilecek miktar sıfırdan büyük ve bakiyenizden az olmalıdır!!");
                }
            }
     
            
        }

        static void Main(string[] args)
        {
        }
    }
}
