using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RearrangingWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string inputPhrase = Console.ReadLine();

            string reversedPhrase = ReversWords(inputPhrase);
            Console.Write("Перевернутое предложение:  ");
            Console.Write(reversedPhrase);
            Console.ReadKey();
        }

        static string ReversWords(string inputPhrase)
        {
            string[] words = inputPhrase.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
