using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Patika1
{
    internal class Program
    {      
        public static void Main(string[] args)
        {
            Console.Write("Metin Giriniz: ");
            string metin = Console.ReadLine().ToLower();
            char[] sesliHarfler;

            int sesliHarfSayisi = 0;

            foreach (char harf in metin)
            {
                if (harf == 'a' || harf == 'e' || harf == 'ı' || harf == 'i' || harf == 'o' || harf == 'ö' || harf == 'u' || harf == 'ü')
                    sesliHarfSayisi++;
            }

            sesliHarfler = new char[sesliHarfSayisi];

            int i = 0;
            foreach (char harf in metin)
            {
                if (harf == 'a' || harf == 'e' || harf == 'ı' || harf == 'i' || harf == 'o' || harf == 'ö' || harf == 'u' || harf == 'ü')
                {
                    sesliHarfler[i] = harf;
                    i++;
                }
            }

            
            Console.WriteLine($"Girilen metinde {sesliHarfSayisi} adet sesli harf vardır. Bu harfler:");
            foreach (char harf in sesliHarfler)
                Console.WriteLine(harf);

            Console.ReadLine();
        }
    }    
}
