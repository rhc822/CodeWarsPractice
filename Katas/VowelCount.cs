using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace CodeWarsPractice
{
    class VowelCount
    {
        /*
        Return the number (count) of vowels in the given string.

        We will consider a, e, i, o, u as vowels for this Kata (but not y).

        The input string will only consist of lower case letters and/or spaces.
        */
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            Regex rx = new Regex("[aeiou]", RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(str);
            foreach(Match match in matches)
            {
                vowelCount++;
            }
            return vowelCount;





            // Your code here
            
            //return vowelCount;
        }
    }
}
