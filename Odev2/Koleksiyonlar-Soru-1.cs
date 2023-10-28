using System;
using System.Collections;

namespace Patika1
{
    internal class Program
    {      
        public static void Main(string[] args)
        {
            int[] numbers = new int[20];
            ArrayList asal = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();

            for (int i = 0; i < numbers.Length; i++)
            {
                if ((int.TryParse(Console.ReadLine(), out int n)) && n > 0)
                    numbers[i] = n;               
                else
                    throw new Exception("Sadece pozitif tam sayılar giriniz!");           
            }
            
            foreach (int number in numbers)
            { 
                if (IsPrime(number))
                    asal.Add(number);
                else
                    asalOlmayan.Add(number);
            }

            asal.Sort();
            asalOlmayan.Sort();

            Console.WriteLine("Asal Sayılar: ");
            foreach (var item in asal)
                Console.WriteLine(item);

            Console.WriteLine("Asal Olmayan Sayılar: ");
            foreach (var item in asalOlmayan)
                Console.WriteLine(item);

            Console.WriteLine($"Asal Sayıların sayısı: {asal.Count}");
            Console.WriteLine($"Asal Olmayan Sayıların sayısı: {asalOlmayan.Count}");

            Console.WriteLine($"Asal Sayıların Ortalaması: {Avarage(asal)}");
            Console.WriteLine($"Asal Olmayan Sayıların Ortalaması: {Avarage(asalOlmayan)}");


            Console.ReadLine();
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;

            #region uzun asal yontem
            //if (number <= 1)
            //    return false;
            //if (number <= 3)
            //    return true;
            //if (number % 2 == 0 || number % 3 == 0)
            //    return false;

            //for (int i = 5; i * i <= number; i+=6)
            //{
            //    if (number % i == 0 || number % (i + 2) == 0)
            //        return false;
            //}

            //return true;
            #endregion
        }

        static float Avarage(ArrayList arrayList)
        {
            float sum = 0;

            foreach(int item in arrayList)
                sum += item;

            return sum / arrayList.Count;       
        }
    }    
}
