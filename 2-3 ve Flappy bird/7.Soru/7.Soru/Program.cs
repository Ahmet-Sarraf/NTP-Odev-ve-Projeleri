using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Soru
{
    class Program
    {
        static int M = 5; // Labirent yüksekliği
        static int N = 5; // Labirent genişliği

        static void Main()
        {
            var yol = SehreUlasmaYolu();

            if (yol != null)
            {
                Console.WriteLine("Şehre ulaşılabilen yol:");
                foreach (var adim in yol)
                {
                    Console.WriteLine($"({adim.Item1}, {adim.Item2})");
                }
            }
            else
            {
                Console.WriteLine("Şehir kayboldu!");
            }
            Console.ReadKey();
        }

        static List<Tuple<int, int>> SehreUlasmaYolu()
        {
            Queue<Tuple<int, int>> kuyruk = new Queue<Tuple<int, int>>();
            bool[,] ziyaretEdildi = new bool[M, N];
            Dictionary<Tuple<int, int>, Tuple<int, int>> onceki = new Dictionary<Tuple<int, int>, Tuple<int, int>>();

            kuyruk.Enqueue(Tuple.Create(0, 0));
            ziyaretEdildi[0, 0] = true;

            // Dört yön: yukarı, aşağı, sağ, sol
            int[] dx = { 0, 1, 0, -1 };
            int[] dy = { 1, 0, -1, 0 };

            while (kuyruk.Count > 0)
            {
                var hucre = kuyruk.Dequeue();
                int x = hucre.Item1;
                int y = hucre.Item2;

                // Hedef hücreye ulaştık mı?
                if (x == M - 1 && y == N - 1)
                {
                    return YoluOlustur(onceki, hucre);
                }

                for (int i = 0; i < 4; i++)
                {
                    int yeniX = x + dx[i];
                    int yeniY = y + dy[i];

                    // Yeni hücre sınırların içinde mi?
                    if (yeniX >= 0 && yeniX < M && yeniY >= 0 && yeniY < N)
                    {
                        // Hücreye daha önce gidilmedi mi ve kurallara uyuyor mu?
                        if (!ziyaretEdildi[yeniX, yeniY] && KuralKontrol(yeniX, yeniY))
                        {
                            ziyaretEdildi[yeniX, yeniY] = true;
                            kuyruk.Enqueue(Tuple.Create(yeniX, yeniY));
                            onceki[Tuple.Create(yeniX, yeniY)] = hucre;
                        }
                    }
                }
            }
            return null; // Ulaşılabilecek yol yok
        }

        static bool KuralKontrol(int x, int y)
        {
            return BasamaklarAsalMi(x) && BasamaklarAsalMi(y) && ((x + y) % (x * y) == 0);
        }

        static bool BasamaklarAsalMi(int sayi)
        {
            int birler = sayi % 10;
            int onlar = sayi / 10;

            return AsalMi(birler) && AsalMi(onlar);
        }

        static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false;
            for (int i = 2; i * i <= sayi; i++)
            {
                if (sayi % i == 0) return false;
            }
            return true;
        }

        static List<Tuple<int, int>> YoluOlustur(Dictionary<Tuple<int, int>, Tuple<int, int>> onceki, Tuple<int, int> hedef)
        {
            List<Tuple<int, int>> yol = new List<Tuple<int, int>>();
            var hucre = hedef;

            while (hucre != null)
            {
                yol.Insert(0, hucre);
                onceki.TryGetValue(hucre, out hucre);
            }
            return yol;
        }
    }
}
