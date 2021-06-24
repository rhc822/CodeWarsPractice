using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsPractice
{
    class ExesAndOhs
    {
        /*
        
        Check to see if a string has the same amount of 'x's and 'o's.The method must return a boolean and be case insensitive.The string can contain any char.

        Examples input/output:

        XO("ooxx") => true
        XO("xooxx") => false
        XO("ooxXm") => true
        XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
        XO("zzoo") => false
        
        */

        public static bool ContainsEqualXsAndOs(string myString)
        {
            string lowerString = myString.ToLower(); //make everything lowercase
            int numXs = lowerString.Count(c => c == 'x'); //count the xs, set to variable
            int numOs = lowerString.Count(c => c == 'o'); //count the xs, set to variable
            if (numXs == numOs)
                {
                    return true;
                }
            else
                {
                    return false;
                }
            //Console.WriteLine($"Number of Xs are: {numXs} and Number of Os are: {numOs}");
            //return true;

            //count the os, set to variable
            //compare x and o variables to determine equality, if same return true
            //else return false
        }



    }
}
