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
            int wordCount;
            string[] words;
            
            Console.Write("Gireceğiniz kelime adedini giriniz: ");
            wordCount = int.Parse(Console.ReadLine());

            words = new string[wordCount];

            for (int i = 0; i < wordCount; i++)
            {
                Console.Write($"{i+1}. Kelime: ");
                words[i] = Console.ReadLine();
            }

            foreach (string item in words)
            {              
                Console.Write($"{item} ");               
            }


            Console.ReadLine();
        }
    }
}
