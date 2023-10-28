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
            int[] numbers = new int[20];
            int[] minNumber = new int[3];
            int[] maxNumber = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            for (int i = 0; i < 3; i++)
            {
                minNumber[i] = numbers[i];
                maxNumber[i] = numbers[numbers.Length - i - 1];
            }

            Console.WriteLine("Sıralanmış Sayılar: ");
            foreach (int i in numbers)
                Console.WriteLine(i);

            Console.WriteLine("En Küçük 3 Sayı: ");
            foreach (int i in minNumber)
                Console.WriteLine(i);

            Console.WriteLine("En Büyük 3 Sayı: ");
            foreach (int i in maxNumber)
                Console.WriteLine(i);

            Console.WriteLine($"En Küçük 3 Sayının Ortalaması: {Avarage(minNumber)}");
            Console.WriteLine($"En Büyük 3 Sayının Ortalaması: {Avarage(maxNumber)}");
            Console.WriteLine($"En Küçük 3 Ve En Büyük 3 Sayılarının Ortalama Toplamları: {Avarage(minNumber) + Avarage(maxNumber)}");

            Console.ReadLine();
        }

        static float Avarage(Array array)
        {
            float sum = 0;

            foreach(int item in array)
                sum += item;

            return sum / 3;       
        }
    }    
}
