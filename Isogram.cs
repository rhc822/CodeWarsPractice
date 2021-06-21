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
            if (word.Contains("a"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }







    }
}
