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
            string a = s1 + s2;
            IEnumerable<char> b =  a.Distinct();
            string c = "";
            //string a = "\n\n\n" + s1 + "\n" + s2;
            foreach (var i in b)
            {
                c += Convert.ToString(i);
            }
            return c;
            // isolate the unique characters in each string
            // compare the strings together to determine the unique values between the two
            // 
        }
    }
}
