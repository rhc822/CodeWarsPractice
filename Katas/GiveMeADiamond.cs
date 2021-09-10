using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsPractice
{

    /*********************************************
        
        Jamie is a programmer, and James' girlfriend. She likes diamonds, and wants a diamond string from James. Since James doesn't know how to make this happen, he needs your help.

        Task
        You need to return a string that looks like a diamond shape when printed on the screen, using asterisk (*) characters. Trailing spaces should be removed, and every line must be terminated with a newline character (\n).

        Return null/nil/None/... if the input is an even number or negative, as it is not possible to print a diamond of even or negative size.

        Examples
        A size 3 diamond:

         *
        ***
         *
         
        ...which would appear as a string of " *\n***\n *\n"

        A size 5 diamond:

          *
         ***
        *****
         ***
          *
        
        ...that is:

        "  *\n ***\n*****\n ***\n  *\n"

    
    *********************************************/

    class Diamond
    {
        public static string Print(int n)
        {
            // Validation check if negative / even number / or 0
            if (n < 0 || n % 2 == 0 || n == 0)
            {
                return null;
                //throw new Exception("The integer cannot be negative or be even. Please enter an odd number.");
            }

            string[] a = new string[n];
            int arrayIndexMidpoint = ((int)Math.Ceiling((double)n / 2))-1; // Find the index midpoint of the provided integer

            // Series of checks that create the string array based on conditions
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < arrayIndexMidpoint; j++)
                    {
                        a[0] += " ";
                    }
                    a[0] += "*\n";
                }

                else if (i == arrayIndexMidpoint)
                {
                    for (int j = 0; j < n; j++)
                    {
                        a[i] += "*";
                    }
                    a[i] += "\n";
                }

                else if (i > arrayIndexMidpoint)
                {
                    a[i] = a[arrayIndexMidpoint - (Math.Abs(arrayIndexMidpoint - i))];
                }

                else 
                {
                    for (int j = 0; j < arrayIndexMidpoint - i; j++)
                    {
                        a[i] += " ";
                    }
                    for (int k = 0; k < (i * 2) + 1; k++)
                    {
                        a[i] += "*";
                    }
                    a[i] += "\n";
                }
            }

            return string.Join("", a); // Put the array in a single string

        }
    }
}
