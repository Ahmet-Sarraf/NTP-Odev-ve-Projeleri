using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Soru
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bir matematiksel ifade girin (örn. 3 + 4 * 2 / (1 - 5) ^ 2 ^ 3):");
            string expression = Console.ReadLine();

            try
            {
                Console.WriteLine("\nÇözüm Süreci:");
                double result = EvaluateExpression(expression);
                Console.WriteLine($"\nSonuç: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: Geçersiz bir ifade girdiniz.");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        // İşlem önceliklerini göz önüne alarak ifadeyi çözen metod
        static double EvaluateExpression(string expression)
        {
            // Parantezler içindeki ifadeleri çöz
            while (expression.Contains("("))
            {
                int openIndex = expression.LastIndexOf('(');
                int closeIndex = expression.IndexOf(')', openIndex);
                string innerExpression = expression.Substring(openIndex + 1, closeIndex - openIndex - 1);
                double innerResult = EvaluateExpression(innerExpression);
                expression = expression.Substring(0, openIndex) + innerResult + expression.Substring(closeIndex + 1);

                Console.WriteLine($"Parantez çözümü: {expression}");
            }

            // Üs alma işlemlerini çöz
            List<string> parts = new List<string>(expression.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            for (int i = 0; i < parts.Count; i++)
            {
                if (parts[i] == "^")
                {
                    double left = double.Parse(parts[i - 1]);
                    double right = double.Parse(parts[i + 1]);
                    double powerResult = Math.Pow(left, right);
                    parts[i - 1] = powerResult.ToString();
                    parts.RemoveAt(i);
                    parts.RemoveAt(i);
                    i--;

                    Console.WriteLine($"Üs çözümü: {string.Join(" ", parts)}");
                }
            }

            // Çarpma ve bölme işlemlerini çöz
            for (int i = 0; i < parts.Count; i++)
            {
                if (parts[i] == "*" || parts[i] == "/")
                {
                    double left = double.Parse(parts[i - 1]);
                    double right = double.Parse(parts[i + 1]);
                    double result = (parts[i] == "*") ? left * right : left / right;
                    parts[i - 1] = result.ToString();
                    parts.RemoveAt(i);
                    parts.RemoveAt(i);
                    i--;

                    Console.WriteLine($"Çarpma/Bölme çözümü: {string.Join(" ", parts)}");
                }
            }

            // Toplama ve çıkarma işlemlerini çöz
            double finalResult = double.Parse(parts[0]);
            for (int i = 1; i < parts.Count; i += 2)
            {
                string op = parts[i];
                double nextValue = double.Parse(parts[i + 1]);
                finalResult = (op == "+") ? finalResult + nextValue : finalResult - nextValue;

                Console.WriteLine($"Toplama/Çıkarma çözümü: {finalResult}");
            }

            return finalResult;
        }
    }
}
