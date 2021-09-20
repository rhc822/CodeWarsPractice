using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsPractice
{

    /*****************************
    
    Take 2 strings s1 and s2 including only letters from a to z. Return a new sorted string, the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.

    Examples:
    a = "xyaabbbccccdefww"
    b = "xxxxyyyyabklmopq"
    longest(a, b) -> "abcdefklmopqwxy"

    a = "abcdefghijklmnopqrstuvwxyz"
    longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"

    *****************************/

    class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            string combinedStrings = s1 + s2;
            IEnumerable<char> charEnum =  combinedStrings.Distinct().OrderBy(z => z);
            string distinctSortedString = "";
            foreach (var i in charEnum)
            {
                distinctSortedString += Convert.ToString(i);
            }
            return distinctSortedString;
        }
    }
}
