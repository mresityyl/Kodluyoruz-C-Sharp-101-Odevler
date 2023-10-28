using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number;
            int[] numbers;

            Console.Write("Pozitif Bir Sayı Giriniz: ");
            string message = isParseInt(Console.ReadLine(), out number);
            Console.WriteLine(message);

            numbers = new int[number];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{i + 1}. Sayıyı Giriniz: ");
                string message1 = isParseInt(Console.ReadLine(), out numbers[i]);
                Console.WriteLine(message1);
            }

            Console.WriteLine("Yazdığınız Sayıların Çift Ve Sıralanmış Hali: ");
            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    Console.Write($"{item} ");
                }
            }


            Console.ReadLine();
        }

        public static string isParseInt(string param, out int number)
        {
            return int.TryParse(param, out number) && number > 0
                ? ""
                : string.IsNullOrWhiteSpace(param) ? "Alan boş bırakılmaz." : "Geçerli bir pozitif tamsayı girmediniz.";

        }
    }


}