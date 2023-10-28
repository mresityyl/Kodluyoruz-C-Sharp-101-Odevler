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
            Console.Write("Lütfen cümlenizi yazınız: ");
            string sentence = Console.ReadLine();
            Console.WriteLine("Kelime sayısı :" + sentence.WordCount());
            Console.WriteLine("Harf sayısı :" + sentence.NumbersOfLetters());


            Console.ReadLine();
        }        
    }
    public static class Extension
    {
        public static int WordCount(this string str)
        {
            int count = 0;
            int i = 0;
            while (i < str.Length)
            {
                if (str[i] == ' ')
                    count++;
                i++;
            }
            return ++count;
        }

        public static int NumbersOfLetters(this string str)
        {
            int counter = 0;
            int i = 0;
            while (i < str.Length)
            {
                if (str[i] != ' ')
                    counter++;
                i++;
            }
            return counter;
        }
    }
}
