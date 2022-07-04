using LeetCode.Console.Problems._5.LongestPalindromicSubstring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.Tests.Tests._5.LongestPalindromicSubstringTests
{
    public class LongestPalindromicSubstringTests
    {
        private readonly LongestPalindromicSubstringProblem longestPalindromicSubstring;

        public LongestPalindromicSubstringTests()
        {
            longestPalindromicSubstring = new();
        }

        [Fact]
        public void Test()
        {
            var result = longestPalindromicSubstring.LongestPalindrome("babad");

            Assert.Equal("bab", result);
        }
    }
}
