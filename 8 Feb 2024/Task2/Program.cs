using System;

namespace LongestSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "abcabcbb";
            //string s = "bbbbb";
            //string s = "pwwkew";

            int maxLength = 0;
            int left = 0;
            int right = 0;

            bool[] visited = new bool[128];

            while (right < s.Length)
            {
                if (!visited[s[right]])
                {
                    visited[s[right]] = true;
                    right++;
                    maxLength = Math.Max(maxLength, right - left);
                }
                else
                {
                    visited[s[left]] = false;
                    left++;
                }
            }

            Console.WriteLine(maxLength);
        }
    }
}
