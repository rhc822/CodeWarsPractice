using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsPractice
{
    public static class JadenCasingStrings
    {
        /*
        
        Jaden Smith, the son of Will Smith, is the star of films such as The Karate Kid(2010) and After Earth(2013). Jaden is also known for some of his philosophy that he delivers via Twitter.When writing on Twitter, he is known for almost always capitalizing every word.For simplicity, you'll have to capitalize each word, check out how contractions are expected to be in the example below.

        Your task is to convert strings to how they would be written by Jaden Smith.The strings are actual quotes from Jaden Smith, but they are not capitalized in the same way he originally typed them.

        Example:

        Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
        Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"

        */


        public static string ToJadenCase(this string phrase) // the "this" indicates this is a c sharp 'extension' method
        {
            string jadenCaseSentence = "";
            // loop through the string and look for blank spaces
            for (int i = 0; i < phrase.Length; i++)
            {
               // if (phrase.Length == 1)
                //{
                   // jadenCaseSentence += Convert.ToString(phrase[0]).ToUpper().;
                  //  continue;
                //}
                
                if (phrase[i] == ' ')
                {
                    jadenCaseSentence += phrase[i];
                    // capitalize the beginning letter of the word after the space
                    jadenCaseSentence += Convert.ToString(phrase[i + 1]).ToUpper();
                    i++;
                }

                else
                {
                    jadenCaseSentence += Convert.ToString(phrase[i]);
                } 
                    
            }
            
            Console.WriteLine(jadenCaseSentence);
            return String.Empty;
        }

    }
}
