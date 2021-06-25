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

        public static int Persistence(ulong n)
        {
            if (n <= 9)
            {
                return 0;
            }

            int counter = 0; // Set the counter
            while (n >= 9) // Check for single digit
            {
                counter++; // Increment the counter by one

                var ulongToStringList = new List<string>(); // create a "container" for each digit
                string nToString = n.ToString(); // enables length property in for loop

                for (int i = 0; i < nToString.Length; i++)
                {
                    ulongToStringList.Add(Convert.ToString(nToString[i])); // Ccan't access individual digits of a ulong type via square bracket indexing so first converting to string List
                }

                var stringListtoULongList = new List<ulong>();
                stringListtoULongList = ulongToStringList.ConvertAll(s => Convert.ToUInt64(s)); //now converting back to ulong list
                ulong z = 1; // variable to store the result of calcuations

                for (int j = 0; j < stringListtoULongList.Count; j++)
                {

                    z *= stringListtoULongList[j];
                }

                n = z; // Set the reference variable to the original variable n before again checking condition at beginning of while loop
            }

            return counter;

        }

    }
}
