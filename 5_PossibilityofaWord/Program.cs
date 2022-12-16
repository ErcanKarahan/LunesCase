using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_PossibilityofaWord
{
    class Program
    {
        /// <summary>
        /// The second word checks if it is in the first word and the result is yes or no, in this case yes.
        /// </summary>

        static void Main(string[] args)
        {
            Console.WriteLine(PossibilityWord("abtcd", "cat"));
        }

        static string PossibilityWord(string wordOne, string wordTwo)
        {
            if (string.IsNullOrEmpty(wordOne) ||
                string.IsNullOrEmpty(wordTwo))
            {
                return "No";
            }

            List<char> wordOneList = wordOne.ToList();
            return wordTwo.Any(x => !wordOneList.Contains(x)) ? "No" : "Yes";
        }
    }
}
