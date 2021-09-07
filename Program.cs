using System;
using System.Collections.Generic;

namespace CodeWarsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int myInt = Convert.ToInt16(Console.ReadLine());
            var test = Diamond.Print(myInt);
            Console.WriteLine(test);


            // Dubstep
            //Console.WriteLine(Dubstep.SongDecoder(myString));

            // Vowel Count
            // Console.WriteLine(VowelCount.GetVowelCount(myString));

            // Counting Duplicates
            // Console.WriteLine(CountingDuplicates.DuplicateCount(myString));

            // Jaden Case
            // Console.WriteLine(JadenCasingStrings.ToJadenCase(myString));

            // Square Sum
            // List<int> intList = new List<int>();
            // Console.WriteLine("Enter a number NOW!....please");
            // string myString = Console.ReadLine();
            // foreach(char digit in myString)
            //{
            //    intList.Add(Convert.ToInt32(digit - '0')); // Must subtract from char '0' to get actual digit value instead of internal representation of that value
            //}
            //int[] myIntArray = intList.ToArray();

            //Console.WriteLine(SquareSum.SquareSumCalc(myIntArray));

            // Persistent Bugger
            // Console.WriteLine("Enter a number!");
            // long myLong = Convert.ToInt64(Console.ReadLine());
            // Console.WriteLine(PersistentBugger.Persistence(myLong));

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
