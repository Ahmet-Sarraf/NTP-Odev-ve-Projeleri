using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Soru
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Polinomları toplama ve çıkarma programına hoş geldiniz!");
            Console.WriteLine("Çıkmak için 'exit' yazabilirsiniz.");

            while (true)
            {
                Console.WriteLine("\nİlk polinomu girin (örnek: 2x^2 + 3x - 5):");
                string input1 = Console.ReadLine();
                if (input1.ToLower() == "exit") break;

                Console.WriteLine("İkinci polinomu girin (örnek: x^2 - 4):");
                string input2 = Console.ReadLine();
                if (input2.ToLower() == "exit") break;

                try
                {
                    var poly1 = ParsePolynomial(input1);
                    var poly2 = ParsePolynomial(input2);

                    var sum = AddPolynomials(poly1, poly2);
                    var difference = SubtractPolynomials(poly1, poly2);

                    Console.WriteLine("\nToplama Sonucu: " + PolynomialToString(sum));
                    Console.WriteLine("Çıkarma Sonucu: " + PolynomialToString(difference));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: Geçersiz polinom girişi. Lütfen tekrar deneyin.");
                }
            }
        }

        // Polinomları string olarak alıp terimleri Dictionary şeklinde ayrıştıran metod
        static Dictionary<int, int> ParsePolynomial(string input)
        {
            var polynomial = new Dictionary<int, int>();

            // Polinom terimlerini yakalamak için düzenlenmiş regex kalıbı
            var matches = Regex.Matches(input, @"([+-]?\d*)x\^?(\d*)|([+-]?\d+)");

            foreach (Match match in matches)
            {
                int coefficient = 1;
                int exponent = 0;

                if (match.Groups[1].Success)
                {
                    // Katsayı kısmı
                    string coeffStr = match.Groups[1].Value;
                    if (string.IsNullOrEmpty(coeffStr) || coeffStr == "+") coefficient = 1;
                    else if (coeffStr == "-") coefficient = -1;
                    else coefficient = int.Parse(coeffStr);

                    // Üs kısmı
                    exponent = match.Groups[2].Success && match.Groups[2].Value != "" ? int.Parse(match.Groups[2].Value) : 1;
                }
                else if (match.Groups[3].Success)
                {
                    // Sabit terim
                    coefficient = int.Parse(match.Groups[3].Value);
                    exponent = 0;
                }

                if (polynomial.ContainsKey(exponent))
                    polynomial[exponent] += coefficient;
                else
                    polynomial[exponent] = coefficient;
            }

            return polynomial;
        }

        // İki polinomu toplama işlemi
        static Dictionary<int, int> AddPolynomials(Dictionary<int, int> poly1, Dictionary<int, int> poly2)
        {
            var result = new Dictionary<int, int>(poly1);
            foreach (var term in poly2)
            {
                if (result.ContainsKey(term.Key))
                    result[term.Key] += term.Value;
                else
                    result[term.Key] = term.Value;
            }
            return result;
        }

        // İki polinomu çıkarma işlemi
        static Dictionary<int, int> SubtractPolynomials(Dictionary<int, int> poly1, Dictionary<int, int> poly2)
        {
            var result = new Dictionary<int, int>(poly1);
            foreach (var term in poly2)
            {
                if (result.ContainsKey(term.Key))
                    result[term.Key] -= term.Value;
                else
                    result[term.Key] = -term.Value;
            }
            return result;
        }

        // Polinomu string olarak yazdıran metod
        static string PolynomialToString(Dictionary<int, int> polynomial)
        {
            var result = new List<string>();
            foreach (var term in polynomial)
            {
                int coeff = term.Value;
                int exp = term.Key;

                if (coeff == 0) continue;

                string termStr = coeff > 0 && result.Count > 0 ? "+" : "";
                termStr += coeff == 1 && exp != 0 ? "" : coeff.ToString();
                termStr += exp > 0 ? "x" : "";
                termStr += exp > 1 ? $"^{exp}" : "";

                result.Add(termStr);
            }
            return string.Join(" ", result);
        }
    }
}
