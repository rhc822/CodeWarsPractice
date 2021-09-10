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
            if (n < 0 || n % 2 == 0)
            {
                throw new Exception("The integer cannot be negative or be even. Please enter an odd number.");
            }

            string[] a = new string[n];
            int arrayIndexMidpoint = ((int)Math.Ceiling((double)n / 2))-1;

            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                {
                    a[0] = "*\n";
                }

                //else if (i == a.Length)
                //{
                //    a[i] = "*\n";
                //}

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
                    //a[i] = a[Math.Abs(arrayIndexMidpoint - Array.IndexOf(a, a[i]))];
                }

                else 
                {
                    for (int j = 0; j < i + 2; j++)
                    //for(int j = 0; j < Array.IndexOf(a, a[i+2]); j++)
                    {
                        a[i] += "*";
                    }
                    a[i] += "\n";
                }
            }

            return string.Join("", a);

            //var a = new List<string>();
            //for (int i = n; i < 0; i = i-2)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        a[].Add("*");
            //    }
            //    a[i].Append("\n");
            //}
            //return;



            
            //string a = "*";
            //string newString = "";
            //for (var i = 0; i < n; i++) 
            //    {
            //        newString += a;
            //    }
            //return newString;


            // take in the integer n
            // string base = "*\n"
            // List string diamondList = new List()
            // int counter = 0
            // while (i <= n)
            //  {
            //      base.add(base)
            //      i++
            //  }
            // foreach string s in diamondList
            // {
            //      
            // }
            // print d, n number of times
            // if 3, print this...
            // if 5, print this...
            // better algorithm, hm, 
            //throw new NotImplementedException();
        }
    }
}
