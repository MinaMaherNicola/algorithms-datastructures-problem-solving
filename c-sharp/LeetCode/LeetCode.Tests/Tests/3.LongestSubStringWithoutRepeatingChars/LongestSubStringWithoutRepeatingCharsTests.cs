using LeetCode.Console.Problems._3.LongestSubStringWithoutRepeatingChars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.Tests.Tests._3.LongestSubStringWithoutRepeatingChars
{
    public class LongestSubStringWithoutRepeatingCharsTests
    {
        private readonly LongestSubStringWithoutRepeatingCharsProblem longestSubString;

        public LongestSubStringWithoutRepeatingCharsTests()
        {
            longestSubString = new();
        }

        [Fact]
        public void Adding_String_Of_Length_One_Should_Return_The_String_Length()
        {
            string s = "a";

            int output = longestSubString.LengthOfLongestSubstring(s);

            Assert.Equal(1, output);
        }

        [Fact]
        public void Adding_String_Of_Length_Zero_Should_Return_The_String_Length()
        {
            string s = "";

            int output = longestSubString.LengthOfLongestSubstring(s);

            Assert.Equal(0, output);
        }

        [Fact]
        public void Test_Case_1()
        {
            string s = "abcaa";

            int output = longestSubString.LengthOfLongestSubstring(s);

            Assert.Equal(3, output);
        }

        [Fact]
        public void Test_Case_2()
        {
            string s = "pwwkew";

            int output = longestSubString.LengthOfLongestSubstring(s);

            Assert.Equal(3, output);
        }

        [Fact]
        public void Test_Case_3()
        {
            string s = "au";

            int output = longestSubString.LengthOfLongestSubstring(s);

            Assert.Equal(2, output);
        }

        [Fact]
        public void Test_Case_4()
        {
            string s = "aab";

            int output = longestSubString.LengthOfLongestSubstring(s);

            Assert.Equal(2, output);
        }
    }
}
