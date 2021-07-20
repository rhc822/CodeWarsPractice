using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWarsPractice
{
    class Dubstep
    {
        /*
        Polycarpus works as a DJ in the best Berland nightclub, and he often uses dubstep music in his performance. Recently, he has decided to take a couple of old songs and make dubstep remixes from them.

        Let's assume that a song consists of some number of words (that don't contain WUB). To make the dubstep remix of this song, Polycarpus inserts a certain number of words "WUB" before the first word of the song (the number may be zero), after the last word (the number may be zero), and between words (at least one between any pair of neighbouring words), and then the boy glues together all the words, including "WUB", in one string and plays the song at the club.

        For example, a song with words "I AM X" can transform into a dubstep remix as "WUBWUBIWUBAMWUBWUBX" and cannot transform into "WUBWUBIAMWUBX".

        Recently, Jonny has heard Polycarpus's new dubstep track, but since he isn't into modern music, he decided to find out what was the initial song that Polycarpus remixed. Help Jonny restore the original song.

        Input
        The input consists of a single non-empty string, consisting only of uppercase English letters, the string's length doesn't exceed 200 characters

        Output
        Return the words of the initial song that Polycarpus used to make a dubsteb remix. Separate the words with a space.

        Examples
        songDecoder("WUBWEWUBAREWUBWUBTHEWUBCHAMPIONSWUBMYWUBFRIENDWUB")
          // =>  WE ARE THE CHAMPIONS MY FRIEND
        */
        public static string SongDecoder(string input)
        {
            string myString = input.ToUpper();// all uppercase
            string result = "";
            Regex rx = new Regex(@"(WUB)"); // searches for the 'WUB' pattern
            MatchCollection matches = rx.Matches(myString);

            if (String.IsNullOrEmpty(myString))
            {
                return "\nYou cannot submit an empty string";
            } 

            if (myString.Length > 200)
            {
                return "\nPlease input a string with length less than 200 characters ";
            }

            if (matches.Count() == 0)
            {
                return myString;
            }

            foreach (Match match in matches)
            {
                result = myString.Replace(Convert.ToString(match), " "); // replaces each pattern occurence with empty space
            }

            return string.Join(" ", result.Split().Where(x => x != "")); // removes additional empty spaces

        }
    }
}
