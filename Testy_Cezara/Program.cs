using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cezar
{
    public class Program
    {

        public static string Szyfr(string Word, int Key)
        {
            List<char> Letters = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            List<char> LettersWord = new List<char>();
            List<char> LettersNewWord = new List<char>();

            for (int i = 0; i < Word.Length; i++)
            {
                LettersWord.Add(Word[i]);
            }
            for (int i = 0; i < LettersWord.Count; i++)
            {
                if (Char.IsWhiteSpace(LettersWord[i]))
                {
                    LettersNewWord.Add(LettersWord[i]);
                }
                else
                {
                    if (Letters.IndexOf(LettersWord[i]) + (Key %= 26) > 25)
                    {
                        LettersNewWord.Add(Letters[Letters.IndexOf(LettersWord[i]) + (Key %= 26) - 26]);

                    }
                    else if (Letters.IndexOf(LettersWord[i]) + (Key %= 26) < 0)
                    {
                        LettersNewWord.Add(Letters[Letters.IndexOf(LettersWord[i]) + (Key %= 26) + 26]);
                    }
                    else
                    {
                        LettersNewWord.Add(Letters[Letters.IndexOf(LettersWord[i]) + (Key %= 26)]);

                    }
                }
            }
            Word = string.Join("", LettersNewWord);
            return Word;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj słowo (tylko małe litery i spacje)");
            String Word = Console.ReadLine();

            Console.WriteLine("Podaj klucz do szyfry cezara");
            int Key = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Szyfr(Word, Key));


        }
    }
}
