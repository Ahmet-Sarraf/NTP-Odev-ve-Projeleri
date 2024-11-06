using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Soru
{
    class Program
    {

        public class KiralikArac
        {
            public string Plaka;
            public decimal GunlukUcret;
            public Boolean MusatiMi;
            
            public KiralikArac(string plaka,decimal gunlukUcret)
            {
                Plaka = plaka;
                GunlukUcret = gunlukUcret;
                MusatiMi = true;

            }

            public void AraciKirala()
            {
                if (MusatiMi == true)
                {
                    MusatiMi = false;
                    Console.WriteLine("Araç kiramala başarılı");
                }
                else
                {
                    Console.WriteLine("Bu araç kiralanamaz");
                }
            }

            public void AracıTeslimEt()
            {
                if (MusatiMi == false)
                {
                    MusatiMi = true;
                    Console.WriteLine("Araç teslimi başarılı");
                }
                else
                {
                    Console.WriteLine("Bu araç teslim edilemez");
                }
            }

        }


        static void Main(string[] args)
        {
        }
    }
}
