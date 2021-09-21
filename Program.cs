using System;
using System.Collections.Generic;

namespace CodeWarsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Coupon Code
            Console.WriteLine("Please enter the coupon code");
            string s = Console.ReadLine();
            bool b = TheCouponCode.CheckCoupon
                (s,
                "123",
                DateTime.Today.GetDateTimeFormats('D')[1],
                "September 30, 2021");
            if (b == true)
            {
                Console.WriteLine("\n\nYay! You can use the coupon!");
            }
            else
            {
                Console.WriteLine("\n\nYou can't use this coupon! It's invalid! Are you trying to cheat me!?");
            }

            //TwoToOne
            //Console.WriteLine("Please enter string 1");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("Please enter string 2");
            //string s2 = Console.ReadLine();
            //Console.WriteLine(TwoToOne.Longest(s1, s2));
            

            //Give Me A Diamond
            //Console.WriteLine("Enter a number");
            //int myInt = Convert.ToInt16(Console.ReadLine());
            //var diamondString = Diamond.Print(myInt);
            //Console.WriteLine(diamondString);

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
