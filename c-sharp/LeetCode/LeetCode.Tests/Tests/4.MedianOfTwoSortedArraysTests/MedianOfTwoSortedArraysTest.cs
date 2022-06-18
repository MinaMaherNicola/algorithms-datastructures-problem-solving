using LeetCode.Console.Problems._4.MedianOfTwoSortedArrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.Tests.Tests._4.MedianOfTwoSortedArraysTests
{
    public class MedianOfTwoSortedArraysTest
    {
        private readonly MedianOfTwoSortedArraysProblem median;

        public MedianOfTwoSortedArraysTest()
        {
            median = new();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 5, 8 }, new int[] { 4, 6, 7 }, 5d)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5d)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3 }, 2.0d)]
        public void Test_Cases(int[] arr1, int[] arr2, double answer)
        {
            var result = median.FindMedianSortedArrays(arr1, arr2);

            Assert.Equal(answer, result);
        }
    }
}
