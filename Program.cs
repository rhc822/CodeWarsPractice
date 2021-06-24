using System;

namespace CodeWarsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word!");
            string myString = Console.ReadLine();
            Console.WriteLine(ExesAndOhs.ContainsEqualXsAndOs(myString));
            
            
            
            


            // Isogram: enter a word and set up checks to ensure it is only one word, not phrase or sentence
            //if (word.Contains(" "))
            //{
            //    Console.WriteLine("You must enter only a single word without spaces. Please try again.");
            //    word = Console.ReadLine();
            //}
            //Console.WriteLine(Isogram.IsIsogram(word));
        }


    }
}
