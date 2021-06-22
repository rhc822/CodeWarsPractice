using System;

namespace CodeWarsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word!");
            string word = Console.ReadLine();

            // enter a word and set up checks to ensure it is only one word, not phrase or sentence
            if (word.Contains(" "))
            {
                Console.WriteLine("Enter a word!");
                word = Console.ReadLine();
            }
            Console.WriteLine(Isogram.IsIsogram(word));
        }


    }
}
