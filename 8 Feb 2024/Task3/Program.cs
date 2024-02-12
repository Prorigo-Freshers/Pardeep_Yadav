/* Given a string s, consider all duplicated substrings: (contiguous) substrings of s that occur 2 or more times.
 The occurrences may overlap.Return any duplicated substring that has the longest possible length.
 If s does not have a duplicated substring, the answer is "". */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestDuplicateSubstring
{
    internal class DuplicateSubstring
    {
        public static void Main(string[] args)
        {
            string str = "banana";
            // string str = "abcd";
            DuplicateSubstring dps = new DuplicateSubstring();
            string result = dps.FindLongestDuplicateSubstring(str);

            Console.WriteLine(result);

        }

        public string FindLongestDuplicateSubstring(string str)
        {

            int start = 0;
            int maxLength = 0;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    int length = 0;
                    while (j + length < str.Length && str[i + length] == str[j + length])
                    {
                        length++;
                    }

                    if (length > maxLength)
                    {
                        start = i;
                        maxLength = length;
                    }
                }

            }


            if (maxLength == 0)
            {
                return "";
            }
            else
            {
                return str.Substring(start, maxLength);
            }
        }

    }
}