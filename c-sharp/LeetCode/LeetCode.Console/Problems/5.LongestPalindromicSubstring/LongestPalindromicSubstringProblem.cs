using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Console.Problems._5.LongestPalindromicSubstring
{
    public class LongestPalindromicSubstringProblem
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length == 0 || s.Length == 1)
                return s;

            Dictionary<int, string> table = new();
            int key = -1;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = s.Length - 1; j > i; j--)
                {
                    if (s[i] == s[j])
                    {
                        string challengingString = s.Substring(i, (j - i) + 1);
                        if (challengingString == ReverseString(challengingString) && !table.ContainsKey(challengingString.Length))
                        {
                            table[challengingString.Length] = challengingString;
                            key = challengingString.Length > key ? challengingString.Length : key;
                        }
                    }
                }
            }
            return table[key];
        }

        private string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
