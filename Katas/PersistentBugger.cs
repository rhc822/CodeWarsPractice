using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsPractice
{
    class PersistentBugger
    {
        /*
        
        Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.
        
        For example:
        
        persistence(39) == 3 // because 3*9 = 27, 2*7 = 14, 1*4=4
                      // and 4 has only one digit
                 
        persistence(999) == 4 // because 9*9*9 = 729, 7*2*9 = 126,
                       // 1*2*6 = 12, and finally 1*2 = 2
                  
        persistence(4) == 0 // because 4 is already a one-digit number
        
        */

        public static int Persistence(long n)
        {
            if (n <= 9)
            {
                return 0;
            }

            int counter = 0; // Set the counter

            while (n >= 9) // Check for single digit in this loop
            {
                counter++; // Increment the counter by one

                // Converting to string enables both LENGTH property and individual member (digit) access in loops below
                var stringList = new List<string>();
                string nToString = n.ToString(); 

                for (int i = 0; i < nToString.Length; i++)
                {
                    stringList.Add(Convert.ToString(nToString[i]));
                }

                // Converting back to long list
                var longList = new List<long>();
                longList = stringList.ConvertAll(s => Convert.ToInt64(s));

                // variable to store the result of calcuations below
                long multiplcationResult = 1;

                for (int j = 0; j < longList.Count; j++)
                {

                    multiplcationResult *= longList[j];
                }

                // Set the original variable n to result
                n = multiplcationResult;

            }

            return counter;

        }

    }
}
