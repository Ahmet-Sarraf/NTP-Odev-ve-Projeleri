using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Soru
{
    class Program
    {

        public class Urun
        {
            public string Ad { get; set; }
            public decimal Fiyat { get; set; }
            public decimal Indirim;

            public decimal indirim
            {
                get { return Indirim; }
                set
                {
                    if (value < 0 && value>50)
                    {
                        Indirim = 0;
                    }
                    else
                    {
                        Indirim = value;
                    }
                }
            }

            public Urun(string ad, decimal fiyat)
            {
                Ad = ad;
                Fiyat = fiyat;
                Indirim = 0;
            }

            public decimal IndirimliFiyat()
            {
                return Fiyat - (Fiyat * (indirim / 100));
            }


        }

        static void Main(string[] args)
        {
        }
    }
}
