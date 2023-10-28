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
            int n, m;
            int[] numbers;
            
            Console.Write("Gireceğiniz Sayı adedini giriniz: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("kontrol sağlanacak sayıyı giriniz: ");
            m = int.Parse(Console.ReadLine());

            numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            foreach (int item in numbers)
            {
                if (item == m)
                {
                    Console.WriteLine($"{item} değeri {m} değerine eşit ve tam bölünüyor.");
                }
                if (m % item == 0)
                {
                    Console.WriteLine($"{item} değeri {m} değerine tam bölünüyor.");
                }
            }


            Console.ReadLine();
        }
    }
}
