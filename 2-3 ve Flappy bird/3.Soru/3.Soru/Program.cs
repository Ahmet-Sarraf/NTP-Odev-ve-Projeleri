using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Soru
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            int input;

            // Kullanıcıdan sayıları al
            Console.WriteLine("Ardışık sayı gruplarını tespit etmek için sayı girin (Bitirmek için 0 girin):");
            do
            {
                input = int.Parse(Console.ReadLine());
                if (input != 0) numbers.Add(input);
            } while (input != 0);

            // Ardışık grupları bul ve yazdır
            List<string> ranges = FindConsecutiveGroups(numbers);
            Console.WriteLine("Ardışık sayılar grupları:");
            foreach (string range in ranges)
            {
                Console.WriteLine(range);
            }
            Console.ReadKey();
        }

        // Ardışık sayı gruplarını bulan metod
        static List<string> FindConsecutiveGroups(List<int> numbers)
        {
            List<string> ranges = new List<string>();

            // Listedeki sayıları sıraya koy
            numbers.Sort();

            // Ardışık grupları tespit et
            for (int i = 0; i < numbers.Count; i++)
            {
                int start = numbers[i];
                while (i < numbers.Count - 1 && numbers[i + 1] == numbers[i] + 1)
                {
                    i++;
                }
                int end = numbers[i];

                // Tek sayı mı yoksa aralık mı olduğunu kontrol et
                if (start == end)
                    ranges.Add(start.ToString());
                else
                    ranges.Add($"{start}-{end}");
            }

            return ranges;
        }
    }
}
