using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsPractice
{

    /*
    
    https://www.codewars.com/kata/5202ef17a402dd033c000009/train/csharp

    A string is considered to be in title case if each word in the string is either (a) capitalised (that is, only the first letter of the word is in upper case) or (b) considered to be an exception and put entirely into lower case unless it is the first word, which is always capitalised.

    Write a function that will convert a string into title case, given an optional list of exceptions (minor words). The list of minor words will be given as a string with each word separated by a space. Your function should ignore the case of the minor words string -- it should behave in the same way even if the case of the minor word string is changed.

    ###Arguments (Haskell)

        First argument: space-delimited list of minor words that must always be lowercase except for the first word in the string.
        Second argument: the original string to be converted.
    
    ###Arguments (Other languages)

        First argument (required): the original string to be converted.
        Second argument (optional): space-delimited list of minor words that must always be lowercase except for the first word in the string. The JavaScript/CoffeeScript tests will pass undefined when this argument is unused.
    
    ###Example

        Kata.TitleCase("a clash of KINGS", "a an the of")   => "A Clash of Kings"
        Kata.TitleCase("THE WIND IN THE WILLOWS", "The In") => "The Wind in the Willows"
        Kata.TitleCase("the quick brown fox")               => "The Quick Brown Fox"

    */

    public class TitleCase
    {
        public static string MakeTitleCase(string title, string minorWords = "")
        {
            // make all parameter strings lowercase
            // convert title string and minorWords parameter strings to string arrays
            // for each string in the array make the first letter of the string uppercase
            // if title string contains a word in the minorWords string array, ignore that string
            // convert title string array back to string and return 


            return "test";
        }
    }
}
