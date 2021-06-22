using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsPractice
{
    class Isogram
    {

    /************************************

        An isogram is a word that has no repeating letters, consecutive or non-consecutive.Implement a function that determines whether a string that contains only letters is an isogram.Assume the empty string is an isogram. Ignore letter case.

        isIsogram "Dermatoglyphics" == true
        isIsogram "aba" == false
        isIsogram "moOse" == false -- ignore letter case

    ************************************/

        public static bool IsIsogram(string word)
        {
            //Try using the TRIM to remove the character and then test to see if any more exist 
            char[] test = word.ToCharArray();
            test.Count();
            // loop through each letter of the entered word
            foreach (char letter in word)
            {
                // Count how many times the letter appears in the word
                int result = word.Count(letter);

                // if the result is greater than or equal to two, return false
                if ()
                {
                    return false;
                }
            }
            
            // at the end of the loop return true
            return true;

            
        }







    }
}
