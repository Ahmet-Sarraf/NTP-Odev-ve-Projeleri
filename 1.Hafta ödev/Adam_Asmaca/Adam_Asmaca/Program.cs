using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam_Asmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[81]
            {
                "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara",
            "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman",
            "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa",
            "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce",
            "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep",
            "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul",
            "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu",
            "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli",
            "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla",
            "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya",
            "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Sivas", "Şırnak", "Tekirdağ",
            "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat",
            "Zonguldak"
            };
            Random random = new Random();
            int ran = random.Next(1, 82); // Rastgele 1'den 81'e kadar bir sayı üretir
            string secilenSehir = sehirler[ran].ToUpper(); // Diziden ürettiği sayıya denk gelen şehri alır ve tamamını büyük harf yapar
            int uzunluk = sehirler[ran].Length;// Seçilen şehrin uzunluğu alınır
            int kalanHak = 5; // Tahmin etme sınırı
            Boolean sonDurum = false; // Oyunu kazanıp kazanmama durumu

            char[] gizliSehir = new string('-', uzunluk).ToCharArray();

            while (kalanHak > 0 && !sonDurum)
            {
                Console.WriteLine("Şehir: " + new string(gizliSehir)); 
                Console.WriteLine("Kalan hak: " + kalanHak);
                Console.WriteLine("1'e basarak şehri tahmin edebilirsiniz veya bir harf tahmin edin:");

                string girdi = Console.ReadLine(); // Kullanıcının girdiği değer

                if (girdi == "1")
                {
                    Console.Write("Şehri tahmin edin: ");
                    string sehirTahmin = Console.ReadLine().ToUpper(); // Şehir tahmininini kullanıcıdan alır ve tamamını büyük harf yapar
                    if (sehirTahmin == secilenSehir) // Yapılan tahmin doğruysa
                    {
                        sonDurum = true;
                    }
                    else //Yapılan tahmin yanlışsa
                    {
                        kalanHak--; // tahmşn etme sınırı azalır
                        Console.WriteLine("Yanlış tahmin! Kalan hak: " + kalanHak);
                    }
                }
                else if (girdi.Length == 1) // 1' e basılmadığı durum
                {
                    char tahmin = Char.ToUpper(girdi[0]); // Kullanıcıdan alınan tahmini büyük harfe çevir
                    bool dogruTahmin = false; // Doğru tahmin durumu

                    // Tahmin edilen harfi seçilen şehirde kontrol eder ve doğru ise "-" yerine harfi yerleştir
                    for (int i = 0; i < secilenSehir.Length; i++)
                    {
                        if (secilenSehir[i] == tahmin)
                        {
                            gizliSehir[i] = tahmin; // Doğru tahmin edilen harf "-" yerine geçiyor
                            dogruTahmin = true; // Doğru tahmin yapıldı
                        }
                    }

                    // Eğer tahmin yanlışsa kalan hak tekrardan azalıyor
                    if (!dogruTahmin)
                    {
                        kalanHak--;
                        Console.WriteLine("Yanlış tahmin! Kalan hak: " + kalanHak);
                    }
                }

                // Tüm harfler doğru tahmin edildiyse oyun kazanılır
                if (new string(gizliSehir) == secilenSehir)
                {
                    sonDurum = true;
                }
            }

            if (sonDurum) //Oyunun kazanılıp kazanılmadığı kontrol edilir
            {
                Console.WriteLine("Tebrikler! Şehri doğru bildiniz: " + secilenSehir);
            }
            else
            {
                Console.WriteLine("Maalesef kaybettiniz. Şehir: " + secilenSehir);
            }

            Console.WriteLine("Çıkmak için rastgele tuşa basınız");
            Console.ReadKey(); // Oyun sonlandırılır
        }
    }
}
