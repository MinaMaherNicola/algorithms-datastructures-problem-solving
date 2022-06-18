using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Console.Problems._3.LongestSubStringWithoutRepeatingChars
{
    public class LongestSubStringWithoutRepeatingCharsProblem
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length <= 1)
            {
                return s.Length;
            }
            int pointerLeft = 0, pointerRight = 1;
            int maxLength = -1;
            string challengingString = s[0].ToString();
            while (pointerRight < s.Length)
            {
                if (!challengingString.Contains(s[pointerRight]))
                {
                    challengingString += s[pointerRight];
                    pointerRight++;
                }
                else
                {
                    if (maxLength < challengingString.Length)
                    {
                        maxLength = challengingString.Length;
                    }
                    pointerLeft++;
                    pointerRight = pointerLeft + 1;
                    challengingString = s[pointerLeft].ToString();
                }
            }
            if (maxLength < challengingString.Length)
            {
                maxLength = challengingString.Length;
            }
            return maxLength;
        }
    }
}
