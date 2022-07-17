using LeetCode.Console.Problems._6.ZigzagConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.Tests.Tests._6.ZigzagConversion
{
    public class ZigzagConversionProblemTests
    {
        private readonly ZigzagConversionProblem zigzagConversionProblem;
        public ZigzagConversionProblemTests()
        {
            zigzagConversionProblem = new();
        }

        [Fact]
        public void Test_Case_One()
        {
            var result = zigzagConversionProblem.Convert("PAYPALISHIRING", 3);

            Assert.Equal("PAHNAPLSIIGYIR", result);
        }

        [Fact]
        public void Test_Case_Two()
        {
            var result = zigzagConversionProblem.Convert("PAYPALISHIRING", 4);

            Assert.Equal("PINALSIGYAHRPI", result);
        }


        [Fact]
        public void Test_Case_Three()
        {
            var result = zigzagConversionProblem.Convert("A", 1);

            Assert.Equal("A", result);
        }

        [Fact]
        public void Test_Case_Four()
        {
            var result = zigzagConversionProblem.Convert("ABCDE", 4);

            Assert.Equal("ABCED", result);
        }
    }
}
