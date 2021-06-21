using System;

namespace CodeWarsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word!");
            string word = Console.ReadLine();
            Console.WriteLine(Isogram.IsIsogram(word));
        }


    }
}
