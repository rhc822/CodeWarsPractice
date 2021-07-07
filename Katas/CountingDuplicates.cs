﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsPractice
{
    public class CountingDuplicates
    {

    /*
    Count the number of Duplicates
    Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. The input string can be assumed to contain only alphabets(both uppercase and lowercase) and numeric digits.

    Examples:
    "abcde" -> 0 # no characters repeats more than once
    "aabbcde" -> 2 # 'a' and 'b'
    "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
    "indivisibility" -> 1 # 'i' occurs six times
    "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
    "aA11" -> 2 # 'a' and '1'
    "ABBA" -> 2 # 'A' and 'B' each occur twice
    */

        public static int DuplicateCount(string str)
        {
            var myList = str.ToLower().ToList();
            int duplicateCounter = 0;
            List<char> uniqueCharacters = new List<char>();
            foreach (char character in myList)
            {
                if (uniqueCharacters.Contains(character))
                    {
                        continue;
                    }
                uniqueCharacters.Add(character);
                int charCounter = str.ToLower().Count(c => c == character);
                if (charCounter >= 2)
                {
                    duplicateCounter++;
                    continue;
                }
            }
            return duplicateCounter;
              
        }

    }
}
