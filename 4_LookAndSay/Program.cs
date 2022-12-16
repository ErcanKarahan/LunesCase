using System;
using System.IO;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;

namespace _4_LookAndSay
{

    /// <summary>
    /// In mathematics, the look-and-say sequence is the sequence of integers beginning as follows:

    /// 1, 11, 21, 1211, 111221, 312211, 13112221, 1113213211, 31131211131221, ... (sequence A005150 in the OEIS).
    /// To generate a member of the sequence from the previous member, read off the digits of the previous member, counting the number of digits in groups of the same digit.For example:
    /// 
    /// 1 is read off as "one 1" or 11.
    /// 11 is read off as "two 1s" or 21.
    /// 21 is read off as "one 2, one 1" or 1211.
    /// 1211 is read off as "one 1, one 2, two 1s" or 111221.
    /// 111221 is read off as "three 1s, two 2s, one 1" or 312211.
    /// The look-and-say sequence was analyzed by John Conway[1] after he was introduced to it by one of his students at a party.[2][3]
    ///  The idea of the look-and-say sequence is similar to that of run-length encoding.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string num = "1";

            foreach (int i in Enumerable.Range(1, 10))
            {
                Console.WriteLine(num);
                num = LookAndSay(num);
            }
        }

        static string LookAndSay(string number)
        {
            StringBuilder result = new StringBuilder();

            char repeat = number[0];
            number = number.Substring(1, number.Length - 1) + " ";
            int times = 1;

            foreach (char actual in number)
            {
                if (actual != repeat)
                {
                    result.Append(Convert.ToString(times) + repeat);
                    times = 1;
                    repeat = actual;
                }
                else
                {
                    times += 1;
                }
            }
            return result.ToString();
        }
    }
}
